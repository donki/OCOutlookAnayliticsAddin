
namespace OCAnalytics
{
    partial class OCAnalyticsPanel
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcAnalisi = new System.Windows.Forms.TabControl();
            this.tpAnalisis = new System.Windows.Forms.TabPage();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.tbCategoriaNoPlaneadas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCategoriaNoComputable = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCategoriaFestivos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btRefresh = new System.Windows.Forms.Button();
            this.nudHorasLaboralesPlanificadas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudHorasLaborales = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFinPeriodo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtInicioPeriodo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasPlanificablesPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasPlanificadasPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasRestantesPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerceHorasPlaneadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasPlanificablesHoy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasPlanificadasHoy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasRestantesHoy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasNoPlaneadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcAnalisi.SuspendLayout();
            this.tpAnalisis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            this.tpConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasLaboralesPlanificadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasLaborales)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAnalisi
            // 
            this.tcAnalisi.Controls.Add(this.tpAnalisis);
            this.tcAnalisi.Controls.Add(this.tpConfiguration);
            this.tcAnalisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAnalisi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcAnalisi.Location = new System.Drawing.Point(0, 0);
            this.tcAnalisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcAnalisi.MinimumSize = new System.Drawing.Size(1021, 0);
            this.tcAnalisi.Name = "tcAnalisi";
            this.tcAnalisi.SelectedIndex = 0;
            this.tcAnalisi.Size = new System.Drawing.Size(1093, 449);
            this.tcAnalisi.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcAnalisi.TabIndex = 1;
            // 
            // tpAnalisis
            // 
            this.tpAnalisis.Controls.Add(this.dgvResumen);
            this.tpAnalisis.Location = new System.Drawing.Point(4, 29);
            this.tpAnalisis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpAnalisis.Name = "tpAnalisis";
            this.tpAnalisis.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpAnalisis.Size = new System.Drawing.Size(1085, 416);
            this.tpAnalisis.TabIndex = 0;
            this.tpAnalisis.Text = "Análisis";
            this.tpAnalisis.UseVisualStyleBackColor = true;
            // 
            // dgvResumen
            // 
            this.dgvResumen.AllowUserToAddRows = false;
            this.dgvResumen.AllowUserToDeleteRows = false;
            this.dgvResumen.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResumen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Periodo,
            this.HorasPlanificablesPeriodo,
            this.HorasPlanificadasPeriodo,
            this.HorasRestantesPeriodo,
            this.PerceHorasPlaneadas,
            this.HorasPlanificablesHoy,
            this.HorasPlanificadasHoy,
            this.HorasRestantesHoy,
            this.HorasNoPlaneadas});
            this.dgvResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResumen.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvResumen.Location = new System.Drawing.Point(4, 5);
            this.dgvResumen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.ReadOnly = true;
            this.dgvResumen.Size = new System.Drawing.Size(1077, 406);
            this.dgvResumen.TabIndex = 4;
            this.dgvResumen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResumen_CellContentClick);
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.Controls.Add(this.tbCategoriaNoPlaneadas);
            this.tpConfiguration.Controls.Add(this.label7);
            this.tpConfiguration.Controls.Add(this.tbCategoriaNoComputable);
            this.tpConfiguration.Controls.Add(this.label6);
            this.tpConfiguration.Controls.Add(this.tbCategoriaFestivos);
            this.tpConfiguration.Controls.Add(this.label5);
            this.tpConfiguration.Controls.Add(this.btRefresh);
            this.tpConfiguration.Controls.Add(this.nudHorasLaboralesPlanificadas);
            this.tpConfiguration.Controls.Add(this.label4);
            this.tpConfiguration.Controls.Add(this.nudHorasLaborales);
            this.tpConfiguration.Controls.Add(this.label3);
            this.tpConfiguration.Controls.Add(this.dtFinPeriodo);
            this.tpConfiguration.Controls.Add(this.label2);
            this.tpConfiguration.Controls.Add(this.dtInicioPeriodo);
            this.tpConfiguration.Controls.Add(this.label1);
            this.tpConfiguration.Location = new System.Drawing.Point(4, 29);
            this.tpConfiguration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpConfiguration.Size = new System.Drawing.Size(1085, 416);
            this.tpConfiguration.TabIndex = 1;
            this.tpConfiguration.Text = "Configuración";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            // 
            // tbCategoriaNoPlaneadas
            // 
            this.tbCategoriaNoPlaneadas.Location = new System.Drawing.Point(832, 117);
            this.tbCategoriaNoPlaneadas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCategoriaNoPlaneadas.Name = "tbCategoriaNoPlaneadas";
            this.tbCategoriaNoPlaneadas.Size = new System.Drawing.Size(215, 27);
            this.tbCategoriaNoPlaneadas.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(640, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Categoria No Planeadas";
            // 
            // tbCategoriaNoComputable
            // 
            this.tbCategoriaNoComputable.Location = new System.Drawing.Point(833, 80);
            this.tbCategoriaNoComputable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCategoriaNoComputable.Name = "tbCategoriaNoComputable";
            this.tbCategoriaNoComputable.Size = new System.Drawing.Size(215, 27);
            this.tbCategoriaNoComputable.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(641, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Categoria No Computable";
            // 
            // tbCategoriaFestivos
            // 
            this.tbCategoriaFestivos.Location = new System.Drawing.Point(832, 39);
            this.tbCategoriaFestivos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCategoriaFestivos.Name = "tbCategoriaFestivos";
            this.tbCategoriaFestivos.Size = new System.Drawing.Size(215, 27);
            this.tbCategoriaFestivos.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(640, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categoria Festivos";
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.White;
            this.btRefresh.Image = global::OCAnalytics.Properties.Resources.refresh;
            this.btRefresh.Location = new System.Drawing.Point(25, 106);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(62, 53);
            this.btRefresh.TabIndex = 8;
            this.btRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // nudHorasLaboralesPlanificadas
            // 
            this.nudHorasLaboralesPlanificadas.DecimalPlaces = 2;
            this.nudHorasLaboralesPlanificadas.Location = new System.Drawing.Point(527, 79);
            this.nudHorasLaboralesPlanificadas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudHorasLaboralesPlanificadas.Name = "nudHorasLaboralesPlanificadas";
            this.nudHorasLaboralesPlanificadas.Size = new System.Drawing.Size(103, 27);
            this.nudHorasLaboralesPlanificadas.TabIndex = 7;
            this.nudHorasLaboralesPlanificadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudHorasLaboralesPlanificadas.Value = new decimal(new int[] {
            400,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Horas laborables planificables";
            // 
            // nudHorasLaborales
            // 
            this.nudHorasLaborales.DecimalPlaces = 2;
            this.nudHorasLaborales.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudHorasLaborales.Location = new System.Drawing.Point(198, 81);
            this.nudHorasLaborales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudHorasLaborales.Name = "nudHorasLaborales";
            this.nudHorasLaborales.Size = new System.Drawing.Size(103, 27);
            this.nudHorasLaborales.TabIndex = 5;
            this.nudHorasLaborales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudHorasLaborales.UseWaitCursor = true;
            this.nudHorasLaborales.Value = new decimal(new int[] {
            640,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Horas laborables";
            // 
            // dtFinPeriodo
            // 
            this.dtFinPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinPeriodo.Location = new System.Drawing.Point(472, 37);
            this.dtFinPeriodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtFinPeriodo.Name = "dtFinPeriodo";
            this.dtFinPeriodo.Size = new System.Drawing.Size(140, 27);
            this.dtFinPeriodo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fin Periodo";
            // 
            // dtInicioPeriodo
            // 
            this.dtInicioPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicioPeriodo.Location = new System.Drawing.Point(197, 37);
            this.dtInicioPeriodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtInicioPeriodo.Name = "dtInicioPeriodo";
            this.dtInicioPeriodo.Size = new System.Drawing.Size(140, 27);
            this.dtInicioPeriodo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio Periodo";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Periodo
            // 
            this.Periodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Periodo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            this.Periodo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Periodo.Width = 85;
            // 
            // HorasPlanificablesPeriodo
            // 
            this.HorasPlanificablesPeriodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.HorasPlanificablesPeriodo.DefaultCellStyle = dataGridViewCellStyle3;
            this.HorasPlanificablesPeriodo.HeaderText = "Horas Planificables Periodo";
            this.HorasPlanificablesPeriodo.Name = "HorasPlanificablesPeriodo";
            this.HorasPlanificablesPeriodo.ReadOnly = true;
            this.HorasPlanificablesPeriodo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HorasPlanificablesPeriodo.Width = 215;
            // 
            // HorasPlanificadasPeriodo
            // 
            this.HorasPlanificadasPeriodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.HorasPlanificadasPeriodo.DefaultCellStyle = dataGridViewCellStyle4;
            this.HorasPlanificadasPeriodo.HeaderText = "Horas Planificadas Periodo";
            this.HorasPlanificadasPeriodo.Name = "HorasPlanificadasPeriodo";
            this.HorasPlanificadasPeriodo.ReadOnly = true;
            this.HorasPlanificadasPeriodo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HorasPlanificadasPeriodo.Width = 211;
            // 
            // HorasRestantesPeriodo
            // 
            this.HorasRestantesPeriodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.HorasRestantesPeriodo.DefaultCellStyle = dataGridViewCellStyle5;
            this.HorasRestantesPeriodo.HeaderText = "Horas Restantes Periodo";
            this.HorasRestantesPeriodo.Name = "HorasRestantesPeriodo";
            this.HorasRestantesPeriodo.ReadOnly = true;
            this.HorasRestantesPeriodo.Width = 195;
            // 
            // PerceHorasPlaneadas
            // 
            this.PerceHorasPlaneadas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.PerceHorasPlaneadas.DefaultCellStyle = dataGridViewCellStyle6;
            this.PerceHorasPlaneadas.HeaderText = "% Horas Planeadas Periodo";
            this.PerceHorasPlaneadas.Name = "PerceHorasPlaneadas";
            this.PerceHorasPlaneadas.ReadOnly = true;
            this.PerceHorasPlaneadas.Width = 215;
            // 
            // HorasPlanificablesHoy
            // 
            this.HorasPlanificablesHoy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.HorasPlanificablesHoy.DefaultCellStyle = dataGridViewCellStyle7;
            this.HorasPlanificablesHoy.HeaderText = "Horas Planificables Hoy";
            this.HorasPlanificablesHoy.Name = "HorasPlanificablesHoy";
            this.HorasPlanificablesHoy.ReadOnly = true;
            this.HorasPlanificablesHoy.Width = 191;
            // 
            // HorasPlanificadasHoy
            // 
            this.HorasPlanificadasHoy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.HorasPlanificadasHoy.DefaultCellStyle = dataGridViewCellStyle8;
            this.HorasPlanificadasHoy.HeaderText = "Horas Planificadas Hoy";
            this.HorasPlanificadasHoy.Name = "HorasPlanificadasHoy";
            this.HorasPlanificadasHoy.ReadOnly = true;
            this.HorasPlanificadasHoy.Width = 187;
            // 
            // HorasRestantesHoy
            // 
            this.HorasRestantesHoy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.HorasRestantesHoy.DefaultCellStyle = dataGridViewCellStyle9;
            this.HorasRestantesHoy.HeaderText = "Horas Restantes Hoy";
            this.HorasRestantesHoy.Name = "HorasRestantesHoy";
            this.HorasRestantesHoy.ReadOnly = true;
            this.HorasRestantesHoy.Width = 171;
            // 
            // HorasNoPlaneadas
            // 
            this.HorasNoPlaneadas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.HorasNoPlaneadas.DefaultCellStyle = dataGridViewCellStyle10;
            this.HorasNoPlaneadas.HeaderText = "Horas No Planeadas";
            this.HorasNoPlaneadas.Name = "HorasNoPlaneadas";
            this.HorasNoPlaneadas.ReadOnly = true;
            this.HorasNoPlaneadas.Width = 168;
            // 
            // OCAnalyticsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tcAnalisi);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(766, 0);
            this.Name = "OCAnalyticsPanel";
            this.Size = new System.Drawing.Size(1093, 449);
            this.Click += new System.EventHandler(this.OCAnalyticsPanel_Click);
            this.Enter += new System.EventHandler(this.OCAnalyticsPanel_Enter);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OCAnalyticsPanel_MouseClick);
            this.tcAnalisi.ResumeLayout(false);
            this.tpAnalisis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            this.tpConfiguration.ResumeLayout(false);
            this.tpConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasLaboralesPlanificadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasLaborales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvResumen;
        public System.Windows.Forms.TabControl tcAnalisi;
        public System.Windows.Forms.TabPage tpAnalisis;
        public System.Windows.Forms.TabPage tpConfiguration;
        private System.Windows.Forms.DateTimePicker dtFinPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtInicioPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudHorasLaboralesPlanificadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudHorasLaborales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.TextBox tbCategoriaFestivos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbCategoriaNoComputable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCategoriaNoPlaneadas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasPlanificablesPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasPlanificadasPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasRestantesPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerceHorasPlaneadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasPlanificablesHoy;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasPlanificadasHoy;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasRestantesHoy;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasNoPlaneadas;
    }
}
