namespace UczelniaApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.osobyPanel = new System.Windows.Forms.Panel();
            this.osobyNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.osobyNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.osobyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uczelnia = new UczelniaApp.Uczelnia();
            this.osobyNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.osobyNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.osobyNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.osobyNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.osobyNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.osobyNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.osobyNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.osobyNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.osobyNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.osobyNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.osobySaveButton = new System.Windows.Forms.ToolStripButton();
            this.osobySearchButton = new System.Windows.Forms.ToolStripButton();
            this.osobySearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.osobyStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.osobyNavigatorSeprator3 = new System.Windows.Forms.ToolStripSeparator();
            this.osobyGridView = new System.Windows.Forms.DataGridView();
            this.nrOsoby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataurodzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plec = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.podrozePanel = new System.Windows.Forms.Panel();
            this.podrozeNazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.podrozeImieTextBox = new System.Windows.Forms.TextBox();
            this.podrozeNazwiskoLabel = new System.Windows.Forms.Label();
            this.podrozeImieLabel = new System.Windows.Forms.Label();
            this.podrozePictureBox = new System.Windows.Forms.PictureBox();
            this.zdjeciaListView = new System.Windows.Forms.ListView();
            this.Image = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zdjeciaImageList = new System.Windows.Forms.ImageList(this.components);
            this.podrozeOsobyNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.podrozeGridView = new System.Windows.Forms.DataGridView();
            this.nr_podorozy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podrozeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raportPanel = new System.Windows.Forms.Panel();
            this.raportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.raportGridVIew = new System.Windows.Forms.DataGridView();
            this.NrOsoby1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscPodrozy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.osobyTableAdapter = new UczelniaApp.UczelniaTableAdapters.osobyTableAdapter();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.osobyPage = new System.Windows.Forms.TabPage();
            this.podrozePage = new System.Windows.Forms.TabPage();
            this.raportyPage = new System.Windows.Forms.TabPage();
            this.osobyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osobyNavigator)).BeginInit();
            this.osobyNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osobyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uczelnia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobyGridView)).BeginInit();
            this.podrozePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.podrozePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podrozeOsobyNavigator)).BeginInit();
            this.podrozeOsobyNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.podrozeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podrozeBindingSource)).BeginInit();
            this.raportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raportChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raportGridVIew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.osobyPage.SuspendLayout();
            this.podrozePage.SuspendLayout();
            this.raportyPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // osobyPanel
            // 
            this.osobyPanel.Controls.Add(this.osobyNavigator);
            this.osobyPanel.Controls.Add(this.osobyGridView);
            this.osobyPanel.Location = new System.Drawing.Point(3, 3);
            this.osobyPanel.Name = "osobyPanel";
            this.osobyPanel.Size = new System.Drawing.Size(708, 437);
            this.osobyPanel.TabIndex = 0;
            // 
            // osobyNavigator
            // 
            this.osobyNavigator.AddNewItem = this.osobyNavigatorAddNewItem;
            this.osobyNavigator.BindingSource = this.osobyBindingSource;
            this.osobyNavigator.CountItem = this.osobyNavigatorCountItem;
            this.osobyNavigator.DeleteItem = this.osobyNavigatorDeleteItem;
            this.osobyNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobyNavigatorMoveFirstItem,
            this.osobyNavigatorMovePreviousItem,
            this.osobyNavigatorSeparator,
            this.osobyNavigatorPositionItem,
            this.osobyNavigatorCountItem,
            this.osobyNavigatorSeparator1,
            this.osobyNavigatorMoveNextItem,
            this.osobyNavigatorMoveLastItem,
            this.osobyNavigatorSeparator2,
            this.osobyNavigatorAddNewItem,
            this.osobyNavigatorDeleteItem,
            this.osobySaveButton,
            this.osobySearchButton,
            this.osobySearchTextBox,
            this.osobyStripLabel,
            this.osobyNavigatorSeprator3});
            this.osobyNavigator.Location = new System.Drawing.Point(0, 0);
            this.osobyNavigator.MoveFirstItem = this.osobyNavigatorMoveFirstItem;
            this.osobyNavigator.MoveLastItem = this.osobyNavigatorMoveLastItem;
            this.osobyNavigator.MoveNextItem = this.osobyNavigatorMoveNextItem;
            this.osobyNavigator.MovePreviousItem = this.osobyNavigatorMovePreviousItem;
            this.osobyNavigator.Name = "osobyNavigator";
            this.osobyNavigator.PositionItem = this.osobyNavigatorPositionItem;
            this.osobyNavigator.Size = new System.Drawing.Size(708, 25);
            this.osobyNavigator.TabIndex = 1;
            this.osobyNavigator.Text = "osobyNavigator";
            // 
            // osobyNavigatorAddNewItem
            // 
            this.osobyNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.osobyNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("osobyNavigatorAddNewItem.Image")));
            this.osobyNavigatorAddNewItem.Name = "osobyNavigatorAddNewItem";
            this.osobyNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.osobyNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.osobyNavigatorAddNewItem.Text = "Add new";
            // 
            // osobyBindingSource
            // 
            this.osobyBindingSource.DataMember = "osoby";
            this.osobyBindingSource.DataSource = this.uczelnia;
            // 
            // uczelnia
            // 
            this.uczelnia.DataSetName = "Uczelnia";
            this.uczelnia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // osobyNavigatorCountItem
            // 
            this.osobyNavigatorCountItem.Name = "osobyNavigatorCountItem";
            this.osobyNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.osobyNavigatorCountItem.Text = "of {0}";
            this.osobyNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // osobyNavigatorDeleteItem
            // 
            this.osobyNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.osobyNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("osobyNavigatorDeleteItem.Image")));
            this.osobyNavigatorDeleteItem.Name = "osobyNavigatorDeleteItem";
            this.osobyNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.osobyNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.osobyNavigatorDeleteItem.Text = "Delete";
            // 
            // osobyNavigatorMoveFirstItem
            // 
            this.osobyNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.osobyNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("osobyNavigatorMoveFirstItem.Image")));
            this.osobyNavigatorMoveFirstItem.Name = "osobyNavigatorMoveFirstItem";
            this.osobyNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.osobyNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.osobyNavigatorMoveFirstItem.Text = "Move first";
            // 
            // osobyNavigatorMovePreviousItem
            // 
            this.osobyNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.osobyNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("osobyNavigatorMovePreviousItem.Image")));
            this.osobyNavigatorMovePreviousItem.Name = "osobyNavigatorMovePreviousItem";
            this.osobyNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.osobyNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.osobyNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // osobyNavigatorSeparator
            // 
            this.osobyNavigatorSeparator.Name = "osobyNavigatorSeparator";
            this.osobyNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // osobyNavigatorPositionItem
            // 
            this.osobyNavigatorPositionItem.AccessibleName = "Position";
            this.osobyNavigatorPositionItem.AutoSize = false;
            this.osobyNavigatorPositionItem.Name = "osobyNavigatorPositionItem";
            this.osobyNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.osobyNavigatorPositionItem.Text = "0";
            this.osobyNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // osobyNavigatorSeparator1
            // 
            this.osobyNavigatorSeparator1.Name = "osobyNavigatorSeparator1";
            this.osobyNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // osobyNavigatorMoveNextItem
            // 
            this.osobyNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.osobyNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("osobyNavigatorMoveNextItem.Image")));
            this.osobyNavigatorMoveNextItem.Name = "osobyNavigatorMoveNextItem";
            this.osobyNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.osobyNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.osobyNavigatorMoveNextItem.Text = "Move next";
            // 
            // osobyNavigatorMoveLastItem
            // 
            this.osobyNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.osobyNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("osobyNavigatorMoveLastItem.Image")));
            this.osobyNavigatorMoveLastItem.Name = "osobyNavigatorMoveLastItem";
            this.osobyNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.osobyNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.osobyNavigatorMoveLastItem.Text = "Move last";
            // 
            // osobyNavigatorSeparator2
            // 
            this.osobyNavigatorSeparator2.Name = "osobyNavigatorSeparator2";
            this.osobyNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // osobySaveButton
            // 
            this.osobySaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.osobySaveButton.Image = global::UczelniaApp.Properties.Resources.save;
            this.osobySaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.osobySaveButton.Name = "osobySaveButton";
            this.osobySaveButton.Size = new System.Drawing.Size(23, 22);
            this.osobySaveButton.Text = "Zapisz";
            this.osobySaveButton.Click += new System.EventHandler(this.osobySaveButton_Click);
            // 
            // osobySearchButton
            // 
            this.osobySearchButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.osobySearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.osobySearchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.osobySearchButton.Image = ((System.Drawing.Image)(resources.GetObject("osobySearchButton.Image")));
            this.osobySearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.osobySearchButton.Name = "osobySearchButton";
            this.osobySearchButton.Size = new System.Drawing.Size(47, 22);
            this.osobySearchButton.Text = "Szukaj";
            this.osobySearchButton.Click += new System.EventHandler(this.osobySearchButton_Click);
            // 
            // osobySearchTextBox
            // 
            this.osobySearchTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.osobySearchTextBox.Name = "osobySearchTextBox";
            this.osobySearchTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // osobyStripLabel
            // 
            this.osobyStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.osobyStripLabel.Name = "osobyStripLabel";
            this.osobyStripLabel.Size = new System.Drawing.Size(60, 22);
            this.osobyStripLabel.Text = "Nazwisko:";
            // 
            // osobyNavigatorSeprator3
            // 
            this.osobyNavigatorSeprator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.osobyNavigatorSeprator3.Name = "osobyNavigatorSeprator3";
            this.osobyNavigatorSeprator3.Size = new System.Drawing.Size(6, 25);
            // 
            // osobyGridView
            // 
            this.osobyGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.osobyGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.osobyGridView.AutoGenerateColumns = false;
            this.osobyGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.osobyGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.osobyGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.osobyGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.osobyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.osobyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrOsoby,
            this.imie,
            this.nazwisko,
            this.dataurodzenia,
            this.plec});
            this.osobyGridView.DataSource = this.osobyBindingSource;
            this.osobyGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.osobyGridView.Location = new System.Drawing.Point(0, 28);
            this.osobyGridView.Name = "osobyGridView";
            this.osobyGridView.Size = new System.Drawing.Size(705, 315);
            this.osobyGridView.TabIndex = 0;
            // 
            // nrOsoby
            // 
            this.nrOsoby.DataPropertyName = "nr_osoby";
            this.nrOsoby.HeaderText = "nr_osoby";
            this.nrOsoby.Name = "nrOsoby";
            // 
            // imie
            // 
            this.imie.DataPropertyName = "imie";
            this.imie.HeaderText = "imie";
            this.imie.Name = "imie";
            // 
            // nazwisko
            // 
            this.nazwisko.DataPropertyName = "nazwisko";
            this.nazwisko.HeaderText = "nazwisko";
            this.nazwisko.Name = "nazwisko";
            // 
            // dataurodzenia
            // 
            this.dataurodzenia.DataPropertyName = "data_urodzenia";
            this.dataurodzenia.HeaderText = "data_urodzenia";
            this.dataurodzenia.Name = "dataurodzenia";
            // 
            // plec
            // 
            this.plec.DataPropertyName = "plec";
            this.plec.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.plec.HeaderText = "plec";
            this.plec.Items.AddRange(new object[] {
            "K",
            "M"});
            this.plec.Name = "plec";
            this.plec.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.plec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // podrozePanel
            // 
            this.podrozePanel.Controls.Add(this.podrozeNazwiskoTextBox);
            this.podrozePanel.Controls.Add(this.podrozeImieTextBox);
            this.podrozePanel.Controls.Add(this.podrozeNazwiskoLabel);
            this.podrozePanel.Controls.Add(this.podrozeImieLabel);
            this.podrozePanel.Controls.Add(this.podrozePictureBox);
            this.podrozePanel.Controls.Add(this.zdjeciaListView);
            this.podrozePanel.Controls.Add(this.podrozeOsobyNavigator);
            this.podrozePanel.Controls.Add(this.podrozeGridView);
            this.podrozePanel.Location = new System.Drawing.Point(6, 3);
            this.podrozePanel.Name = "podrozePanel";
            this.podrozePanel.Size = new System.Drawing.Size(702, 592);
            this.podrozePanel.TabIndex = 4;
            // 
            // podrozeNazwiskoTextBox
            // 
            this.podrozeNazwiskoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobyBindingSource, "nazwisko", true));
            this.podrozeNazwiskoTextBox.Location = new System.Drawing.Point(264, 35);
            this.podrozeNazwiskoTextBox.Name = "podrozeNazwiskoTextBox";
            this.podrozeNazwiskoTextBox.ReadOnly = true;
            this.podrozeNazwiskoTextBox.Size = new System.Drawing.Size(144, 20);
            this.podrozeNazwiskoTextBox.TabIndex = 8;
            // 
            // podrozeImieTextBox
            // 
            this.podrozeImieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobyBindingSource, "imie", true));
            this.podrozeImieTextBox.Location = new System.Drawing.Point(51, 35);
            this.podrozeImieTextBox.Name = "podrozeImieTextBox";
            this.podrozeImieTextBox.ReadOnly = true;
            this.podrozeImieTextBox.Size = new System.Drawing.Size(145, 20);
            this.podrozeImieTextBox.TabIndex = 7;
            // 
            // podrozeNazwiskoLabel
            // 
            this.podrozeNazwiskoLabel.AutoSize = true;
            this.podrozeNazwiskoLabel.Location = new System.Drawing.Point(202, 38);
            this.podrozeNazwiskoLabel.Name = "podrozeNazwiskoLabel";
            this.podrozeNazwiskoLabel.Size = new System.Drawing.Size(56, 13);
            this.podrozeNazwiskoLabel.TabIndex = 6;
            this.podrozeNazwiskoLabel.Text = "Nazwisko:";
            // 
            // podrozeImieLabel
            // 
            this.podrozeImieLabel.AutoSize = true;
            this.podrozeImieLabel.Location = new System.Drawing.Point(10, 38);
            this.podrozeImieLabel.Name = "podrozeImieLabel";
            this.podrozeImieLabel.Size = new System.Drawing.Size(29, 13);
            this.podrozeImieLabel.TabIndex = 5;
            this.podrozeImieLabel.Text = "Imię:";
            // 
            // podrozePictureBox
            // 
            this.podrozePictureBox.Location = new System.Drawing.Point(146, 234);
            this.podrozePictureBox.Name = "podrozePictureBox";
            this.podrozePictureBox.Size = new System.Drawing.Size(477, 262);
            this.podrozePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.podrozePictureBox.TabIndex = 4;
            this.podrozePictureBox.TabStop = false;
            // 
            // zdjeciaListView
            // 
            this.zdjeciaListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Image});
            this.zdjeciaListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.zdjeciaListView.Location = new System.Drawing.Point(3, 219);
            this.zdjeciaListView.Name = "zdjeciaListView";
            this.zdjeciaListView.Size = new System.Drawing.Size(118, 370);
            this.zdjeciaListView.SmallImageList = this.zdjeciaImageList;
            this.zdjeciaListView.TabIndex = 3;
            this.zdjeciaListView.UseCompatibleStateImageBehavior = false;
            this.zdjeciaListView.View = System.Windows.Forms.View.List;
            this.zdjeciaListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.zdjeciaListView_MouseClick);
            // 
            // Image
            // 
            this.Image.Text = "Images";
            this.Image.Width = 105;
            // 
            // zdjeciaImageList
            // 
            this.zdjeciaImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.zdjeciaImageList.ImageSize = new System.Drawing.Size(168, 100);
            this.zdjeciaImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // podrozeOsobyNavigator
            // 
            this.podrozeOsobyNavigator.AddNewItem = null;
            this.podrozeOsobyNavigator.BindingSource = this.osobyBindingSource;
            this.podrozeOsobyNavigator.CountItem = this.toolStripLabel1;
            this.podrozeOsobyNavigator.DeleteItem = null;
            this.podrozeOsobyNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3});
            this.podrozeOsobyNavigator.Location = new System.Drawing.Point(0, 0);
            this.podrozeOsobyNavigator.MoveFirstItem = this.toolStripButton3;
            this.podrozeOsobyNavigator.MoveLastItem = this.toolStripButton6;
            this.podrozeOsobyNavigator.MoveNextItem = this.toolStripButton5;
            this.podrozeOsobyNavigator.MovePreviousItem = this.toolStripButton4;
            this.podrozeOsobyNavigator.Name = "podrozeOsobyNavigator";
            this.podrozeOsobyNavigator.PositionItem = this.toolStripTextBox1;
            this.podrozeOsobyNavigator.Size = new System.Drawing.Size(702, 25);
            this.podrozeOsobyNavigator.TabIndex = 2;
            this.podrozeOsobyNavigator.Text = "podrozeNavigator";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move first";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move previous";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move next";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move last";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // podrozeGridView
            // 
            this.podrozeGridView.AllowUserToAddRows = false;
            this.podrozeGridView.AllowUserToDeleteRows = false;
            this.podrozeGridView.AutoGenerateColumns = false;
            this.podrozeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.podrozeGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.podrozeGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.podrozeGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.podrozeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.podrozeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nr_podorozy,
            this.data,
            this.miejscowosc,
            this.opis});
            this.podrozeGridView.DataSource = this.podrozeBindingSource;
            this.podrozeGridView.Location = new System.Drawing.Point(0, 66);
            this.podrozeGridView.Name = "podrozeGridView";
            this.podrozeGridView.ReadOnly = true;
            this.podrozeGridView.Size = new System.Drawing.Size(699, 150);
            this.podrozeGridView.TabIndex = 0;
            this.podrozeGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.podrozeGridView_MouseClick);
            // 
            // nr_podorozy
            // 
            this.nr_podorozy.DataPropertyName = "nr_podorozy";
            this.nr_podorozy.HeaderText = "NrPodrozy";
            this.nr_podorozy.Name = "nr_podorozy";
            this.nr_podorozy.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // miejscowosc
            // 
            this.miejscowosc.DataPropertyName = "nazwa";
            this.miejscowosc.HeaderText = "Miejscowość";
            this.miejscowosc.Name = "miejscowosc";
            this.miejscowosc.ReadOnly = true;
            // 
            // opis
            // 
            this.opis.DataPropertyName = "opis";
            this.opis.HeaderText = "Opis";
            this.opis.Name = "opis";
            this.opis.ReadOnly = true;
            // 
            // podrozeBindingSource
            // 
            this.podrozeBindingSource.DataSource = this.uczelnia;
            this.podrozeBindingSource.Position = 0;
            // 
            // raportPanel
            // 
            this.raportPanel.Controls.Add(this.raportChart);
            this.raportPanel.Controls.Add(this.raportGridVIew);
            this.raportPanel.Location = new System.Drawing.Point(6, 16);
            this.raportPanel.Name = "raportPanel";
            this.raportPanel.Size = new System.Drawing.Size(705, 589);
            this.raportPanel.TabIndex = 5;
            // 
            // raportChart
            // 
            chartArea1.Name = "ChartArea1";
            this.raportChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.raportChart.Legends.Add(legend1);
            this.raportChart.Location = new System.Drawing.Point(18, 179);
            this.raportChart.Name = "raportChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.raportChart.Series.Add(series1);
            this.raportChart.Size = new System.Drawing.Size(641, 365);
            this.raportChart.TabIndex = 1;
            this.raportChart.Text = "raportChart";
            // 
            // raportGridVIew
            // 
            this.raportGridVIew.AllowUserToAddRows = false;
            this.raportGridVIew.AllowUserToDeleteRows = false;
            this.raportGridVIew.AutoGenerateColumns = false;
            this.raportGridVIew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.raportGridVIew.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.raportGridVIew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.raportGridVIew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NrOsoby1,
            this.imie1,
            this.nazwisko1,
            this.iloscPodrozy});
            this.raportGridVIew.DataSource = this.chartBindingSource;
            this.raportGridVIew.Dock = System.Windows.Forms.DockStyle.Top;
            this.raportGridVIew.Location = new System.Drawing.Point(0, 0);
            this.raportGridVIew.Name = "raportGridVIew";
            this.raportGridVIew.ReadOnly = true;
            this.raportGridVIew.Size = new System.Drawing.Size(705, 150);
            this.raportGridVIew.TabIndex = 0;
            this.raportGridVIew.Click += new System.EventHandler(this.raportGridVIew_Click);
            // 
            // NrOsoby1
            // 
            this.NrOsoby1.DataPropertyName = "nr_osoby";
            this.NrOsoby1.HeaderText = "NrOsoby";
            this.NrOsoby1.Name = "NrOsoby1";
            this.NrOsoby1.ReadOnly = true;
            this.NrOsoby1.Visible = false;
            // 
            // imie1
            // 
            this.imie1.DataPropertyName = "imie";
            this.imie1.HeaderText = "Imie";
            this.imie1.Name = "imie1";
            this.imie1.ReadOnly = true;
            // 
            // nazwisko1
            // 
            this.nazwisko1.DataPropertyName = "nazwisko";
            this.nazwisko1.HeaderText = "Nazwisko";
            this.nazwisko1.Name = "nazwisko1";
            this.nazwisko1.ReadOnly = true;
            // 
            // iloscPodrozy
            // 
            this.iloscPodrozy.DataPropertyName = "podrozeCount";
            this.iloscPodrozy.HeaderText = "Ilość Podróży";
            this.iloscPodrozy.Name = "iloscPodrozy";
            this.iloscPodrozy.ReadOnly = true;
            // 
            // osobyTableAdapter
            // 
            this.osobyTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.osobyPage);
            this.tabControl.Controls.Add(this.podrozePage);
            this.tabControl.Controls.Add(this.raportyPage);
            this.tabControl.Location = new System.Drawing.Point(2, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(722, 714);
            this.tabControl.TabIndex = 6;
            // 
            // osobyPage
            // 
            this.osobyPage.Controls.Add(this.osobyPanel);
            this.osobyPage.Location = new System.Drawing.Point(4, 22);
            this.osobyPage.Name = "osobyPage";
            this.osobyPage.Padding = new System.Windows.Forms.Padding(3);
            this.osobyPage.Size = new System.Drawing.Size(714, 688);
            this.osobyPage.TabIndex = 0;
            this.osobyPage.Text = "Osoby";
            this.osobyPage.UseVisualStyleBackColor = true;
            // 
            // podrozePage
            // 
            this.podrozePage.Controls.Add(this.podrozePanel);
            this.podrozePage.Location = new System.Drawing.Point(4, 22);
            this.podrozePage.Name = "podrozePage";
            this.podrozePage.Padding = new System.Windows.Forms.Padding(3);
            this.podrozePage.Size = new System.Drawing.Size(714, 688);
            this.podrozePage.TabIndex = 1;
            this.podrozePage.Text = "Podróże";
            this.podrozePage.UseVisualStyleBackColor = true;
            // 
            // raportyPage
            // 
            this.raportyPage.Controls.Add(this.raportPanel);
            this.raportyPage.Location = new System.Drawing.Point(4, 22);
            this.raportyPage.Name = "raportyPage";
            this.raportyPage.Padding = new System.Windows.Forms.Padding(3);
            this.raportyPage.Size = new System.Drawing.Size(714, 688);
            this.raportyPage.TabIndex = 2;
            this.raportyPage.Text = "Raporty";
            this.raportyPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 718);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.osobyPanel.ResumeLayout(false);
            this.osobyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osobyNavigator)).EndInit();
            this.osobyNavigator.ResumeLayout(false);
            this.osobyNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osobyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uczelnia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobyGridView)).EndInit();
            this.podrozePanel.ResumeLayout(false);
            this.podrozePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.podrozePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podrozeOsobyNavigator)).EndInit();
            this.podrozeOsobyNavigator.ResumeLayout(false);
            this.podrozeOsobyNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.podrozeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podrozeBindingSource)).EndInit();
            this.raportPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raportChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raportGridVIew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.osobyPage.ResumeLayout(false);
            this.podrozePage.ResumeLayout(false);
            this.raportyPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel osobyPanel;
        private System.Windows.Forms.DataGridView osobyGridView;
        private Uczelnia uczelnia;
        private System.Windows.Forms.BindingSource osobyBindingSource;
        private UczelniaTableAdapters.osobyTableAdapter osobyTableAdapter;
        private System.Windows.Forms.BindingNavigator osobyNavigator;
        private System.Windows.Forms.ToolStripButton osobyNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel osobyNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton osobyNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton osobyNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton osobyNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator osobyNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox osobyNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator osobyNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton osobyNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton osobyNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator osobyNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrOsoby;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataurodzenia;
        private System.Windows.Forms.DataGridViewComboBoxColumn plec;
        private System.Windows.Forms.ToolStripButton osobySaveButton;
        private System.Windows.Forms.ToolStripButton osobySearchButton;
        private System.Windows.Forms.ToolStripTextBox osobySearchTextBox;
        private System.Windows.Forms.ToolStripSeparator osobyNavigatorSeprator3;
        private System.Windows.Forms.ToolStripLabel osobyStripLabel;
        private System.Windows.Forms.Panel podrozePanel;
        private System.Windows.Forms.DataGridView podrozeGridView;
        private System.Windows.Forms.BindingSource podrozeBindingSource;
        private System.Windows.Forms.BindingNavigator podrozeOsobyNavigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ImageList zdjeciaImageList;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr_podorozy;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejscowosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis;
        private System.Windows.Forms.ListView zdjeciaListView;
        private System.Windows.Forms.ColumnHeader Image;
        private System.Windows.Forms.TextBox podrozeNazwiskoTextBox;
        private System.Windows.Forms.TextBox podrozeImieTextBox;
        private System.Windows.Forms.Label podrozeNazwiskoLabel;
        private System.Windows.Forms.Label podrozeImieLabel;
        private System.Windows.Forms.PictureBox podrozePictureBox;
        private System.Windows.Forms.Panel raportPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart raportChart;
        private System.Windows.Forms.DataGridView raportGridVIew;
        private System.Windows.Forms.BindingSource chartBindingSource;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage osobyPage;
        private System.Windows.Forms.TabPage podrozePage;
        private System.Windows.Forms.TabPage raportyPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrOsoby1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscPodrozy;
    }
}