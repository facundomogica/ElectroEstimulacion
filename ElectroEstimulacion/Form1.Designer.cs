namespace ElectroEstimulacion
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.Frec_text = new System.Windows.Forms.TextBox();
            this.textBoxFrec = new System.Windows.Forms.TextBox();
            this.textBoxMod = new System.Windows.Forms.TextBox();
            this.Mod_Inf_text = new System.Windows.Forms.TextBox();
            this.textBoxCorr = new System.Windows.Forms.TextBox();
            this.Corr_text = new System.Windows.Forms.TextBox();
            this.Mod_Sup_text = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Tiem_text = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.led_Encendido = new ElectroEstimulacion.Boton_Circular();
            this.boton_Encendido = new ElectroEstimulacion.Boton_Circular();
            this.Bajar_Tiempo = new ElectroEstimulacion.Boton_Circular();
            this.Subir_Tiempo = new ElectroEstimulacion.Boton_Circular();
            this.Bajar_Modulacion_Sup = new ElectroEstimulacion.Boton_Circular();
            this.Subir_Modulacion_Sup = new ElectroEstimulacion.Boton_Circular();
            this.Bajar_Corriente = new ElectroEstimulacion.Boton_Circular();
            this.Subir_Corriente = new ElectroEstimulacion.Boton_Circular();
            this.Bajar_Modulacion_Inf = new ElectroEstimulacion.Boton_Circular();
            this.Subir_Modulacion_Inf = new ElectroEstimulacion.Boton_Circular();
            this.Bajar_Frecuencia = new ElectroEstimulacion.Boton_Circular();
            this.Subir_Frecuencia = new ElectroEstimulacion.Boton_Circular();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigator1.TabIndex = 5;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 37);
            this.button1.TabIndex = 32;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Frec_text
            // 
            this.Frec_text.BackColor = System.Drawing.Color.Black;
            this.Frec_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Frec_text.CausesValidation = false;
            this.Frec_text.Cursor = System.Windows.Forms.Cursors.Default;
            this.Frec_text.Font = new System.Drawing.Font("Digital-7 Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frec_text.ForeColor = System.Drawing.Color.Red;
            this.Frec_text.Location = new System.Drawing.Point(111, 338);
            this.Frec_text.Margin = new System.Windows.Forms.Padding(0);
            this.Frec_text.MaxLength = 7;
            this.Frec_text.Name = "Frec_text";
            this.Frec_text.ReadOnly = true;
            this.Frec_text.Size = new System.Drawing.Size(107, 25);
            this.Frec_text.TabIndex = 33;
            this.Frec_text.Text = "00000";
            this.Frec_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Frec_text.WordWrap = false;
            this.Frec_text.TextChanged += new System.EventHandler(this.Frec_TextChanged);
            // 
            // textBoxFrec
            // 
            this.textBoxFrec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFrec.BackColor = System.Drawing.Color.Gray;
            this.textBoxFrec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFrec.CausesValidation = false;
            this.textBoxFrec.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxFrec.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFrec.Location = new System.Drawing.Point(111, 267);
            this.textBoxFrec.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxFrec.Name = "textBoxFrec";
            this.textBoxFrec.ReadOnly = true;
            this.textBoxFrec.Size = new System.Drawing.Size(107, 25);
            this.textBoxFrec.TabIndex = 36;
            this.textBoxFrec.Text = "Frecuencia";
            this.textBoxFrec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMod
            // 
            this.textBoxMod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMod.BackColor = System.Drawing.Color.Gray;
            this.textBoxMod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMod.CausesValidation = false;
            this.textBoxMod.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxMod.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMod.Location = new System.Drawing.Point(343, 267);
            this.textBoxMod.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxMod.Name = "textBoxMod";
            this.textBoxMod.ReadOnly = true;
            this.textBoxMod.Size = new System.Drawing.Size(107, 25);
            this.textBoxMod.TabIndex = 40;
            this.textBoxMod.Text = "Moduladora";
            this.textBoxMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Mod_Inf_text
            // 
            this.Mod_Inf_text.BackColor = System.Drawing.Color.Black;
            this.Mod_Inf_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mod_Inf_text.CausesValidation = false;
            this.Mod_Inf_text.Cursor = System.Windows.Forms.Cursors.Default;
            this.Mod_Inf_text.Font = new System.Drawing.Font("Digital-7 Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mod_Inf_text.ForeColor = System.Drawing.Color.Red;
            this.Mod_Inf_text.Location = new System.Drawing.Point(313, 338);
            this.Mod_Inf_text.Margin = new System.Windows.Forms.Padding(0);
            this.Mod_Inf_text.MaxLength = 7;
            this.Mod_Inf_text.Name = "Mod_Inf_text";
            this.Mod_Inf_text.ReadOnly = true;
            this.Mod_Inf_text.Size = new System.Drawing.Size(70, 25);
            this.Mod_Inf_text.TabIndex = 39;
            this.Mod_Inf_text.Text = "000";
            this.Mod_Inf_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mod_Inf_text.WordWrap = false;
            // 
            // textBoxCorr
            // 
            this.textBoxCorr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCorr.BackColor = System.Drawing.Color.Gray;
            this.textBoxCorr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCorr.CausesValidation = false;
            this.textBoxCorr.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxCorr.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorr.Location = new System.Drawing.Point(566, 267);
            this.textBoxCorr.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxCorr.Name = "textBoxCorr";
            this.textBoxCorr.ReadOnly = true;
            this.textBoxCorr.Size = new System.Drawing.Size(107, 25);
            this.textBoxCorr.TabIndex = 44;
            this.textBoxCorr.Text = "Corriente";
            this.textBoxCorr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Corr_text
            // 
            this.Corr_text.BackColor = System.Drawing.Color.Black;
            this.Corr_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Corr_text.CausesValidation = false;
            this.Corr_text.Cursor = System.Windows.Forms.Cursors.Default;
            this.Corr_text.Font = new System.Drawing.Font("Digital-7 Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Corr_text.ForeColor = System.Drawing.Color.Red;
            this.Corr_text.Location = new System.Drawing.Point(566, 338);
            this.Corr_text.Margin = new System.Windows.Forms.Padding(0);
            this.Corr_text.MaxLength = 7;
            this.Corr_text.Name = "Corr_text";
            this.Corr_text.ReadOnly = true;
            this.Corr_text.Size = new System.Drawing.Size(107, 25);
            this.Corr_text.TabIndex = 43;
            this.Corr_text.Text = "000";
            this.Corr_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Mod_Sup_text
            // 
            this.Mod_Sup_text.BackColor = System.Drawing.Color.Black;
            this.Mod_Sup_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mod_Sup_text.CausesValidation = false;
            this.Mod_Sup_text.Cursor = System.Windows.Forms.Cursors.Default;
            this.Mod_Sup_text.Font = new System.Drawing.Font("Digital-7 Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mod_Sup_text.ForeColor = System.Drawing.Color.Red;
            this.Mod_Sup_text.Location = new System.Drawing.Point(413, 338);
            this.Mod_Sup_text.Margin = new System.Windows.Forms.Padding(0);
            this.Mod_Sup_text.MaxLength = 7;
            this.Mod_Sup_text.Name = "Mod_Sup_text";
            this.Mod_Sup_text.ReadOnly = true;
            this.Mod_Sup_text.Size = new System.Drawing.Size(70, 25);
            this.Mod_Sup_text.TabIndex = 47;
            this.Mod_Sup_text.Text = "000";
            this.Mod_Sup_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mod_Sup_text.WordWrap = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.Gray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.CausesValidation = false;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(111, 363);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(107, 19);
            this.textBox2.TabIndex = 48;
            this.textBox2.Text = "Hz";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.BackColor = System.Drawing.Color.Gray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.CausesValidation = false;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(322, 363);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(44, 19);
            this.textBox3.TabIndex = 49;
            this.textBox3.Text = "< Hz";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.BackColor = System.Drawing.Color.Gray;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.CausesValidation = false;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(426, 363);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(44, 19);
            this.textBox4.TabIndex = 50;
            this.textBox4.Text = "> Hz";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.BackColor = System.Drawing.Color.Gray;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.CausesValidation = false;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox5.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(597, 363);
            this.textBox5.Margin = new System.Windows.Forms.Padding(0);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(44, 19);
            this.textBox5.TabIndex = 51;
            this.textBox5.Text = "mA";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.BackColor = System.Drawing.Color.Gray;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.CausesValidation = false;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox6.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(597, 213);
            this.textBox6.Margin = new System.Windows.Forms.Padding(0);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(44, 19);
            this.textBox6.TabIndex = 56;
            this.textBox6.Text = "Min";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7.BackColor = System.Drawing.Color.Gray;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.CausesValidation = false;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox7.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(566, 91);
            this.textBox7.Margin = new System.Windows.Forms.Padding(0);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(107, 25);
            this.textBox7.TabIndex = 55;
            this.textBox7.Text = "Tiempo";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tiem_text
            // 
            this.Tiem_text.BackColor = System.Drawing.Color.Black;
            this.Tiem_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tiem_text.CausesValidation = false;
            this.Tiem_text.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tiem_text.Font = new System.Drawing.Font("Digital-7 Italic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiem_text.ForeColor = System.Drawing.Color.Red;
            this.Tiem_text.Location = new System.Drawing.Point(566, 169);
            this.Tiem_text.Margin = new System.Windows.Forms.Padding(0);
            this.Tiem_text.MaxLength = 7;
            this.Tiem_text.Multiline = true;
            this.Tiem_text.Name = "Tiem_text";
            this.Tiem_text.ReadOnly = true;
            this.Tiem_text.Size = new System.Drawing.Size(107, 44);
            this.Tiem_text.TabIndex = 54;
            this.Tiem_text.Text = "00";
            this.Tiem_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox10.BackColor = System.Drawing.Color.Gray;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.CausesValidation = false;
            this.textBox10.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox10.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(85, 91);
            this.textBox10.Margin = new System.Windows.Forms.Padding(0);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(107, 25);
            this.textBox10.TabIndex = 60;
            this.textBox10.Text = "Encendido";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // led_Encendido
            // 
            this.led_Encendido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.led_Encendido.BackColor = System.Drawing.Color.DimGray;
            this.led_Encendido.Cursor = System.Windows.Forms.Cursors.Default;
            this.led_Encendido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.led_Encendido.ForeColor = System.Drawing.SystemColors.Control;
            this.led_Encendido.Location = new System.Drawing.Point(183, 139);
            this.led_Encendido.Margin = new System.Windows.Forms.Padding(1);
            this.led_Encendido.Name = "led_Encendido";
            this.led_Encendido.Size = new System.Drawing.Size(22, 22);
            this.led_Encendido.TabIndex = 58;
            this.led_Encendido.UseVisualStyleBackColor = false;
            // 
            // boton_Encendido
            // 
            this.boton_Encendido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boton_Encendido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.boton_Encendido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_Encendido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Encendido.ForeColor = System.Drawing.SystemColors.Control;
            this.boton_Encendido.Location = new System.Drawing.Point(102, 117);
            this.boton_Encendido.Margin = new System.Windows.Forms.Padding(1);
            this.boton_Encendido.Name = "boton_Encendido";
            this.boton_Encendido.Size = new System.Drawing.Size(70, 67);
            this.boton_Encendido.TabIndex = 57;
            this.boton_Encendido.UseVisualStyleBackColor = false;
            this.boton_Encendido.Click += new System.EventHandler(this.boton_Encendido_Click);
            // 
            // Bajar_Tiempo
            // 
            this.Bajar_Tiempo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bajar_Tiempo.BackColor = System.Drawing.Color.Red;
            this.Bajar_Tiempo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bajar_Tiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bajar_Tiempo.ForeColor = System.Drawing.SystemColors.Control;
            this.Bajar_Tiempo.Image = global::ElectroEstimulacion.Properties.Resources.minusmathsbutton_85758;
            this.Bajar_Tiempo.Location = new System.Drawing.Point(638, 126);
            this.Bajar_Tiempo.Margin = new System.Windows.Forms.Padding(1);
            this.Bajar_Tiempo.Name = "Bajar_Tiempo";
            this.Bajar_Tiempo.Size = new System.Drawing.Size(35, 35);
            this.Bajar_Tiempo.TabIndex = 53;
            this.Bajar_Tiempo.UseVisualStyleBackColor = false;
            this.Bajar_Tiempo.Click += new System.EventHandler(this.Bajar_Tiempo_Click);
            // 
            // Subir_Tiempo
            // 
            this.Subir_Tiempo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Subir_Tiempo.BackColor = System.Drawing.Color.Lime;
            this.Subir_Tiempo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Subir_Tiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subir_Tiempo.ForeColor = System.Drawing.SystemColors.Control;
            this.Subir_Tiempo.Image = global::ElectroEstimulacion.Properties.Resources.plus_button_add_insert_icon_124187;
            this.Subir_Tiempo.Location = new System.Drawing.Point(566, 126);
            this.Subir_Tiempo.Margin = new System.Windows.Forms.Padding(1);
            this.Subir_Tiempo.Name = "Subir_Tiempo";
            this.Subir_Tiempo.Size = new System.Drawing.Size(35, 35);
            this.Subir_Tiempo.TabIndex = 52;
            this.Subir_Tiempo.UseVisualStyleBackColor = false;
            this.Subir_Tiempo.Click += new System.EventHandler(this.Subir_Tiempo_Click);
            // 
            // Bajar_Modulacion_Sup
            // 
            this.Bajar_Modulacion_Sup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bajar_Modulacion_Sup.BackColor = System.Drawing.Color.Red;
            this.Bajar_Modulacion_Sup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bajar_Modulacion_Sup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bajar_Modulacion_Sup.ForeColor = System.Drawing.SystemColors.Control;
            this.Bajar_Modulacion_Sup.Image = global::ElectroEstimulacion.Properties.Resources.minusmathsbutton_85758;
            this.Bajar_Modulacion_Sup.Location = new System.Drawing.Point(457, 302);
            this.Bajar_Modulacion_Sup.Margin = new System.Windows.Forms.Padding(1);
            this.Bajar_Modulacion_Sup.Name = "Bajar_Modulacion_Sup";
            this.Bajar_Modulacion_Sup.Size = new System.Drawing.Size(35, 35);
            this.Bajar_Modulacion_Sup.TabIndex = 46;
            this.Bajar_Modulacion_Sup.UseVisualStyleBackColor = false;
            this.Bajar_Modulacion_Sup.Click += new System.EventHandler(this.Bajar_Modulacion_Sup_Click);
            // 
            // Subir_Modulacion_Sup
            // 
            this.Subir_Modulacion_Sup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Subir_Modulacion_Sup.BackColor = System.Drawing.Color.Lime;
            this.Subir_Modulacion_Sup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Subir_Modulacion_Sup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subir_Modulacion_Sup.ForeColor = System.Drawing.SystemColors.Control;
            this.Subir_Modulacion_Sup.Image = global::ElectroEstimulacion.Properties.Resources.plus_button_add_insert_icon_124187;
            this.Subir_Modulacion_Sup.Location = new System.Drawing.Point(403, 302);
            this.Subir_Modulacion_Sup.Margin = new System.Windows.Forms.Padding(1);
            this.Subir_Modulacion_Sup.Name = "Subir_Modulacion_Sup";
            this.Subir_Modulacion_Sup.Size = new System.Drawing.Size(35, 35);
            this.Subir_Modulacion_Sup.TabIndex = 45;
            this.Subir_Modulacion_Sup.UseVisualStyleBackColor = false;
            this.Subir_Modulacion_Sup.Click += new System.EventHandler(this.Subir_Modulacion_Sup_Click);
            // 
            // Bajar_Corriente
            // 
            this.Bajar_Corriente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bajar_Corriente.BackColor = System.Drawing.Color.Red;
            this.Bajar_Corriente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bajar_Corriente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bajar_Corriente.ForeColor = System.Drawing.SystemColors.Control;
            this.Bajar_Corriente.Image = global::ElectroEstimulacion.Properties.Resources.minusmathsbutton_85758;
            this.Bajar_Corriente.Location = new System.Drawing.Point(638, 302);
            this.Bajar_Corriente.Margin = new System.Windows.Forms.Padding(1);
            this.Bajar_Corriente.Name = "Bajar_Corriente";
            this.Bajar_Corriente.Size = new System.Drawing.Size(35, 35);
            this.Bajar_Corriente.TabIndex = 42;
            this.Bajar_Corriente.UseVisualStyleBackColor = false;
            this.Bajar_Corriente.Click += new System.EventHandler(this.Bajar_Corriente_Click);
            // 
            // Subir_Corriente
            // 
            this.Subir_Corriente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Subir_Corriente.BackColor = System.Drawing.Color.Lime;
            this.Subir_Corriente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Subir_Corriente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subir_Corriente.ForeColor = System.Drawing.SystemColors.Control;
            this.Subir_Corriente.Image = global::ElectroEstimulacion.Properties.Resources.plus_button_add_insert_icon_124187;
            this.Subir_Corriente.Location = new System.Drawing.Point(566, 302);
            this.Subir_Corriente.Margin = new System.Windows.Forms.Padding(1);
            this.Subir_Corriente.Name = "Subir_Corriente";
            this.Subir_Corriente.Size = new System.Drawing.Size(35, 35);
            this.Subir_Corriente.TabIndex = 41;
            this.Subir_Corriente.UseVisualStyleBackColor = false;
            this.Subir_Corriente.Click += new System.EventHandler(this.Subir_Corriente_Click);
            // 
            // Bajar_Modulacion_Inf
            // 
            this.Bajar_Modulacion_Inf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bajar_Modulacion_Inf.BackColor = System.Drawing.Color.Red;
            this.Bajar_Modulacion_Inf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bajar_Modulacion_Inf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bajar_Modulacion_Inf.ForeColor = System.Drawing.SystemColors.Control;
            this.Bajar_Modulacion_Inf.Image = global::ElectroEstimulacion.Properties.Resources.minusmathsbutton_85758;
            this.Bajar_Modulacion_Inf.Location = new System.Drawing.Point(357, 302);
            this.Bajar_Modulacion_Inf.Margin = new System.Windows.Forms.Padding(1);
            this.Bajar_Modulacion_Inf.Name = "Bajar_Modulacion_Inf";
            this.Bajar_Modulacion_Inf.Size = new System.Drawing.Size(35, 35);
            this.Bajar_Modulacion_Inf.TabIndex = 38;
            this.Bajar_Modulacion_Inf.UseVisualStyleBackColor = false;
            this.Bajar_Modulacion_Inf.Click += new System.EventHandler(this.Bajar_Modulacion_Click);
            // 
            // Subir_Modulacion_Inf
            // 
            this.Subir_Modulacion_Inf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Subir_Modulacion_Inf.BackColor = System.Drawing.Color.Lime;
            this.Subir_Modulacion_Inf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Subir_Modulacion_Inf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subir_Modulacion_Inf.ForeColor = System.Drawing.SystemColors.Control;
            this.Subir_Modulacion_Inf.Image = global::ElectroEstimulacion.Properties.Resources.plus_button_add_insert_icon_124187;
            this.Subir_Modulacion_Inf.Location = new System.Drawing.Point(303, 302);
            this.Subir_Modulacion_Inf.Margin = new System.Windows.Forms.Padding(1);
            this.Subir_Modulacion_Inf.Name = "Subir_Modulacion_Inf";
            this.Subir_Modulacion_Inf.Size = new System.Drawing.Size(35, 35);
            this.Subir_Modulacion_Inf.TabIndex = 37;
            this.Subir_Modulacion_Inf.UseVisualStyleBackColor = false;
            this.Subir_Modulacion_Inf.Click += new System.EventHandler(this.Subir_Modulacion_Click);
            // 
            // Bajar_Frecuencia
            // 
            this.Bajar_Frecuencia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bajar_Frecuencia.BackColor = System.Drawing.Color.Red;
            this.Bajar_Frecuencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bajar_Frecuencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bajar_Frecuencia.ForeColor = System.Drawing.SystemColors.Control;
            this.Bajar_Frecuencia.Image = global::ElectroEstimulacion.Properties.Resources.minusmathsbutton_85758;
            this.Bajar_Frecuencia.Location = new System.Drawing.Point(183, 302);
            this.Bajar_Frecuencia.Margin = new System.Windows.Forms.Padding(1);
            this.Bajar_Frecuencia.Name = "Bajar_Frecuencia";
            this.Bajar_Frecuencia.Size = new System.Drawing.Size(35, 35);
            this.Bajar_Frecuencia.TabIndex = 3;
            this.Bajar_Frecuencia.UseVisualStyleBackColor = false;
            this.Bajar_Frecuencia.Click += new System.EventHandler(this.Bajar_Frecuencia_Click);
            // 
            // Subir_Frecuencia
            // 
            this.Subir_Frecuencia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Subir_Frecuencia.BackColor = System.Drawing.Color.Lime;
            this.Subir_Frecuencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Subir_Frecuencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subir_Frecuencia.ForeColor = System.Drawing.SystemColors.Control;
            this.Subir_Frecuencia.Image = global::ElectroEstimulacion.Properties.Resources.plus_button_add_insert_icon_124187;
            this.Subir_Frecuencia.Location = new System.Drawing.Point(111, 302);
            this.Subir_Frecuencia.Margin = new System.Windows.Forms.Padding(1);
            this.Subir_Frecuencia.Name = "Subir_Frecuencia";
            this.Subir_Frecuencia.Size = new System.Drawing.Size(35, 35);
            this.Subir_Frecuencia.TabIndex = 2;
            this.Subir_Frecuencia.UseVisualStyleBackColor = false;
            this.Subir_Frecuencia.Click += new System.EventHandler(this.Subir_Frecuencia_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.led_Encendido);
            this.Controls.Add(this.boton_Encendido);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.Tiem_text);
            this.Controls.Add(this.Bajar_Tiempo);
            this.Controls.Add(this.Subir_Tiempo);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Mod_Sup_text);
            this.Controls.Add(this.Bajar_Modulacion_Sup);
            this.Controls.Add(this.Subir_Modulacion_Sup);
            this.Controls.Add(this.textBoxCorr);
            this.Controls.Add(this.Corr_text);
            this.Controls.Add(this.Bajar_Corriente);
            this.Controls.Add(this.Subir_Corriente);
            this.Controls.Add(this.textBoxMod);
            this.Controls.Add(this.Mod_Inf_text);
            this.Controls.Add(this.Bajar_Modulacion_Inf);
            this.Controls.Add(this.Subir_Modulacion_Inf);
            this.Controls.Add(this.textBoxFrec);
            this.Controls.Add(this.Frec_text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.Bajar_Frecuencia);
            this.Controls.Add(this.Subir_Frecuencia);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button button1;
        protected internal Boton_Circular Subir_Frecuencia;
        protected internal Boton_Circular Bajar_Frecuencia;
        protected internal System.Windows.Forms.TextBox textBoxFrec;
        protected internal System.Windows.Forms.TextBox textBoxMod;
        protected internal Boton_Circular Bajar_Modulacion_Inf;
        protected internal Boton_Circular Subir_Modulacion_Inf;
        protected internal System.Windows.Forms.TextBox textBoxCorr;
        protected internal Boton_Circular Bajar_Corriente;
        protected internal Boton_Circular Subir_Corriente;
        public System.Windows.Forms.TextBox Frec_text;
        public System.Windows.Forms.TextBox Mod_Inf_text;
        public System.Windows.Forms.TextBox Corr_text;
        public System.Windows.Forms.TextBox Mod_Sup_text;
        protected internal Boton_Circular Bajar_Modulacion_Sup;
        protected internal Boton_Circular Subir_Modulacion_Sup;
        protected internal System.Windows.Forms.TextBox textBox2;
        protected internal System.Windows.Forms.TextBox textBox3;
        protected internal System.Windows.Forms.TextBox textBox4;
        protected internal System.Windows.Forms.TextBox textBox5;
        protected internal System.Windows.Forms.TextBox textBox6;
        protected internal System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.TextBox Tiem_text;
        protected internal Boton_Circular Bajar_Tiempo;
        protected internal Boton_Circular Subir_Tiempo;
        protected internal System.Windows.Forms.TextBox textBox10;
        protected internal Boton_Circular led_Encendido;
        protected internal Boton_Circular boton_Encendido;
    }
}

