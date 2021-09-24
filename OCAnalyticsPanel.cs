using System;
using System.Drawing;
using System.Windows.Forms;

namespace OCAnalytics
{
    public partial class OCAnalyticsPanel : UserControl
    {
        private Microsoft.Office.Interop.Outlook.Folder calFolder;
        public OCAnalyticsPanel()
        {
            InitializeComponent();
            this.dtInicioPeriodo.Value = Settings1.Default.IniPeriod;
            this.dtFinPeriodo.Value = Settings1.Default.FinPeriod;
            this.nudHorasLaborales.Value = Settings1.Default.HorasLaborales;
            this.nudHorasLaboralesPlanificadas.Value = Settings1.Default.HorasPlanificables;
            this.tbCategoriaFestivos.Text = Settings1.Default.CategoriaFestivos;
            this.tbCategoriaNoComputable.Text = Settings1.Default.CategoriaNoComputable;
            this.tbCategoriaNoPlaneadas.Text = Settings1.Default.CategoriaNoPlaneada;

            calFolder =
            Globals.ThisAddIn.Application.Session.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderCalendar)
              as Microsoft.Office.Interop.Outlook.Folder;
            calFolder.Items.ItemAdd += ItemAddedEventHandler;
            calFolder.Items.ItemChange += ItemAddedEventHandler;
            calFolder.Items.ItemRemove += ItemRemoveEventHandler;
        }

        private void ItemAddedEventHandler(object Item)
        {
            Refrescar();
        }

        private void ItemRemoveEventHandler()
        {
            Refrescar();
        }




        private void OCAnalyticsPanel_Enter(object sender, EventArgs e)
        {
        }

        private Microsoft.Office.Interop.Outlook.Items GetAppointmentsInRange(Microsoft.Office.Interop.Outlook.Folder folder, DateTime startTime, DateTime endTime)
        {
            string filter = "[Start] >= '" + startTime.ToString("g") + "' AND [End] <= '" + endTime.ToString("g") + "'";
            try
            {
                Microsoft.Office.Interop.Outlook.Items calItems = folder.Items;
                calItems.IncludeRecurrences = true;
                calItems.Sort("[Start]", Type.Missing);
                Microsoft.Office.Interop.Outlook.Items restrictItems = calItems.Restrict(filter);
                if (restrictItems.Count > 0)
                {
                    return restrictItems;
                }
                else
                {
                    return null;
                }
            }
            catch { return null; }
        }

        public void Refrescar()
        {
            timer1.Enabled = false;

            var pSummary = new Summary();




            DateTime start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime end = new DateTime(DateTime.Now.Year, 12, 31);

            Microsoft.Office.Interop.Outlook.Items rangeAppts = GetAppointmentsInRange(calFolder, start, end);

            if (rangeAppts != null)
            {

                pSummary.ProjectSummaryMonths.Clear();

                var MonthPerido = new SummaryMonth();
                MonthPerido.MonthName = this.dtInicioPeriodo.Value.ToString("dd/MM/yyyy") + " - " + this.dtFinPeriodo.Value.ToString("dd/MM/yyyy");
                MonthPerido.BeginOfMonth = Convert.ToDateTime(this.dtInicioPeriodo.Value);
                MonthPerido.EndOfMonth = Convert.ToDateTime(this.dtFinPeriodo.Value);
                MonthPerido.isMonthPeriod = true;
                pSummary.ProjectSummaryMonths.Add(MonthPerido);

                var Today = DateTime.Today;

                foreach (Microsoft.Office.Interop.Outlook.AppointmentItem appt in rangeAppts)
                {

                    if (appt.AllDayEvent)
                    {
                        continue;
                    }
                    if (appt.Categories != null)
                    {
                        if (appt.Categories.Contains(this.tbCategoriaNoComputable.Text))
                        {
                            continue;
                        }
                    }

                    var MonthName = appt.Start.ToString("MM/yyyy");
                    var Month = pSummary.ProjectSummaryMonths.Find((x) => x.MonthName.Equals(MonthName));
                    if (Month == null)
                    {
                        Month = new SummaryMonth();
                        Month.MonthName = MonthName;
                        pSummary.ProjectSummaryMonths.Add(Month);
                        Month.BeginOfMonth = new DateTime(Convert.ToDateTime(appt.Start).Date.Year, Convert.ToDateTime(appt.Start).Date.Month, 1);
                        Month.EndOfMonth = new DateTime(Convert.ToDateTime(appt.Start).Date.Year, Convert.ToDateTime(appt.Start).Date.Month, 1).AddMonths(1).AddDays(-1);
                    }

                    if (appt.Categories != null)
                    {

                        if (appt.Categories.Contains(this.tbCategoriaNoPlaneadas.Text))
                        {

                            Month.TotalNonPlannedHours += (decimal)(appt.End - appt.Start).TotalHours;
                            if ((appt.Start >= this.dtInicioPeriodo.Value.Date) && (this.dtFinPeriodo.Value.Date >= appt.Start))
                            {
                                MonthPerido.TotalNonPlannedHours += (decimal)(appt.End - appt.Start).TotalHours;
                            }
                        }
                    }
                    else
                    {
                        Month.TotalTasks++;
                        Month.TotalHoursPlanned += (decimal)(appt.End - appt.Start).TotalHours;
                        if ((appt.Start >= this.dtInicioPeriodo.Value.Date) && (this.dtFinPeriodo.Value.Date >= appt.Start))
                        {
                            MonthPerido.TotalHoursPlanned += (decimal)(appt.End - appt.Start).TotalHours;

                            if (appt.Start >= Today)
                            {
                                MonthPerido.TotalHoursPlannedToday += (decimal)(appt.End - appt.Start).TotalHours;
                            }
                        }

                        if ((appt.Start >= Today) && (Month.EndOfMonth >= appt.Start))
                        {
                            Month.TotalHoursPlannedToday += (decimal)(appt.End - appt.Start).TotalHours;
                        }
                    }
                }

                pSummary.DailyWorkHours = nudHorasLaboralesPlanificadas.Value;
                pSummary.WeeklyWorkHours = pSummary.DailyWorkHours * 5;
                pSummary.MonthlyWorkHours = pSummary.DailyWorkHours * 20;

                var format = "0.00";

                dgvResumen.Rows.Clear();

                foreach (SummaryMonth psm in pSummary.ProjectSummaryMonths)
                {
                    var getFreeDays = getFreeDaysBetweenDates(calFolder, psm.BeginOfMonth, psm.EndOfMonth) + countWeekEndDaysBetweenDates(psm.BeginOfMonth, psm.EndOfMonth);
                    var getWorkDays = (int)(psm.EndOfMonth - psm.BeginOfMonth).TotalDays + 1;

                    var getFreeDaysToday = 0;
                    var getWorkDaysToday = 0;


                    if (psm.BeginOfMonth < Today)
                    {
                        getFreeDaysToday = getFreeDaysBetweenDates(calFolder, Today, psm.EndOfMonth) + countWeekEndDaysBetweenDates(Today, psm.EndOfMonth);
                        getWorkDaysToday = (int)(psm.EndOfMonth - Today).TotalDays + 1;
                    }
                    else
                    {
                        getFreeDaysToday = getFreeDaysBetweenDates(calFolder, psm.BeginOfMonth, psm.EndOfMonth) + countWeekEndDaysBetweenDates(psm.BeginOfMonth, psm.EndOfMonth);
                        getWorkDaysToday = (int)(psm.EndOfMonth - psm.BeginOfMonth).TotalDays + 1;
                    }


                    psm.TotalWorkHours = (int)((Convert.ToInt32(getWorkDays) - getFreeDays) * nudHorasLaboralesPlanificadas.Value);

                    psm.TotalWorkHoursToday = (int)((Convert.ToInt32(getWorkDaysToday) - getFreeDaysToday) * nudHorasLaboralesPlanificadas.Value);

                    if (psm.TotalHoursPlanned > 0)
                    {
                        psm.PerceProgress = (int)(psm.TotalProgress / psm.TotalHoursPlanned);
                    }

                    if (pSummary.MonthlyWorkHours > 0)
                    {
                        psm.PercePlanned = (int)(psm.TotalHoursPlanned * 100 / psm.TotalWorkHours);
                        if (psm.isMonthPeriod)
                        {
                            pSummary.PercePlannedRange = psm.PercePlanned;
                        }
                    }

                    psm.TotalRemainHours = psm.TotalWorkHours - psm.TotalHoursPlanned;
                    psm.TotalRemainHoursToday = psm.TotalWorkHoursToday - psm.TotalHoursPlannedToday;
                    var row = dgvResumen.Rows.Add(new object[] { 
                        psm.MonthName,
                        psm.TotalWorkHours.ToString(format),
                        psm.TotalHoursPlanned.ToString(format),
                        psm.TotalRemainHours.ToString(format),
                        psm.PercePlanned.ToString(format)+ " %",
                        psm.TotalWorkHoursToday.ToString(format),
                        psm.TotalHoursPlannedToday.ToString(format),
                        psm.TotalRemainHoursToday.ToString(format),
                        psm.TotalNonPlannedHours.ToString(format)
                    });

                    dgvResumen.Rows[row].Cells[4].Style.ForeColor = Color.White;
                    dgvResumen.Rows[row].Cells[7].Style.ForeColor = Color.White;

                    if (psm.PercePlanned > 100)
                    {
                        dgvResumen.Rows[row].Cells[4].Style.BackColor = Color.OrangeRed;

                    }
                    else
                    {
                        dgvResumen.Rows[row].Cells[4].Style.BackColor = Color.Green;
                    }

                    if (psm.TotalRemainHoursToday < 0)
                    {
                        dgvResumen.Rows[row].Cells[7].Style.BackColor = Color.OrangeRed;

                    }
                    else
                    {
                        dgvResumen.Rows[row].Cells[7].Style.BackColor = Color.Green;
                    }

                }

            }

            timer1.Enabled = true;
        }

        private int getFreeDaysBetweenDates(Microsoft.Office.Interop.Outlook.Folder calFolder, DateTime start, DateTime stop)
        {
            Microsoft.Office.Interop.Outlook.Items rangeAppts = GetAppointmentsInRange(calFolder, start, stop);
            int count = 0;
            foreach (Microsoft.Office.Interop.Outlook.AppointmentItem appt in rangeAppts)
            {
                if (appt.Categories != null)
                {
                    if ((appt.AllDayEvent) & (appt.Categories.Contains(this.tbCategoriaFestivos.Text)))
                    {
                        count++;
                    }

                }
            }

            return count;
        }

        private int countWeekEndDaysBetweenDates(DateTime start, DateTime stop)
        {
            int days = 0;
            while (start <= stop)
            {
                if (start.DayOfWeek == DayOfWeek.Saturday || start.DayOfWeek == DayOfWeek.Sunday)
                {
                    ++days;
                }
                start = start.AddDays(1);
            }
            return days;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            Refrescar();
            tcAnalisi.SelectedIndex = 0;
            Settings1.Default.IniPeriod = this.dtInicioPeriodo.Value;
            Settings1.Default.FinPeriod = this.dtFinPeriodo.Value;
            Settings1.Default.HorasLaborales = this.nudHorasLaborales.Value;
            Settings1.Default.HorasPlanificables = this.nudHorasLaboralesPlanificadas.Value;
            Settings1.Default.CategoriaFestivos = this.tbCategoriaFestivos.Text;
            Settings1.Default.CategoriaNoComputable = this.tbCategoriaNoComputable.Text;
            Settings1.Default.Save();

        }

        private void OCAnalyticsPanel_Click(object sender, EventArgs e)
        {
        }

        private void OCAnalyticsPanel_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void dgvResumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
