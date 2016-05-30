namespace RaschetOptimal
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label наименование_средстваLabel;
            System.Windows.Forms.Label скорость_движения__км_чLabel;
            System.Windows.Forms.Label время__необходимое_на_погрузку__минLabel;
            System.Windows.Forms.Label возможность_перевозки_эвакуируемого_населения_за_1_рейс__челLabel;
            System.Windows.Forms.Label влияние_течения_в_затопленной_областиLabel;
            this.database1DataSet = new RaschetOptimal.Database1DataSet();
            this.enginesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enginesTableAdapter = new RaschetOptimal.Database1DataSetTableAdapters.EnginesTableAdapter();
            this.tableAdapterManager = new RaschetOptimal.Database1DataSetTableAdapters.TableAdapterManager();
            this.enginesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.enginesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.enginesDataGridView = new System.Windows.Forms.DataGridView();
            this.наименование_средстваTextBox = new System.Windows.Forms.TextBox();
            this.скорость_движения__км_чTextBox = new System.Windows.Forms.TextBox();
            this.время__необходимое_на_погрузку__минTextBox = new System.Windows.Forms.TextBox();
            this.возможность_перевозки_эвакуируемого_населения_за_1_рейс__челTextBox = new System.Windows.Forms.TextBox();
            this.влияние_течения_в_затопленной_областиCheckBox = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            наименование_средстваLabel = new System.Windows.Forms.Label();
            скорость_движения__км_чLabel = new System.Windows.Forms.Label();
            время__необходимое_на_погрузку__минLabel = new System.Windows.Forms.Label();
            возможность_перевозки_эвакуируемого_населения_за_1_рейс__челLabel = new System.Windows.Forms.Label();
            влияние_течения_в_затопленной_областиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enginesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enginesBindingNavigator)).BeginInit();
            this.enginesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enginesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enginesBindingSource
            // 
            this.enginesBindingSource.DataMember = "Engines";
            this.enginesBindingSource.DataSource = this.database1DataSet;
            // 
            // enginesTableAdapter
            // 
            this.enginesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EnginesTableAdapter = this.enginesTableAdapter;
            this.tableAdapterManager.UpdateOrder = RaschetOptimal.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // enginesBindingNavigator
            // 
            this.enginesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.enginesBindingNavigator.BindingSource = this.enginesBindingSource;
            this.enginesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.enginesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.enginesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.enginesBindingNavigatorSaveItem});
            this.enginesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.enginesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.enginesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.enginesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.enginesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.enginesBindingNavigator.Name = "enginesBindingNavigator";
            this.enginesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.enginesBindingNavigator.Size = new System.Drawing.Size(898, 25);
            this.enginesBindingNavigator.TabIndex = 0;
            this.enginesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // enginesBindingNavigatorSaveItem
            // 
            this.enginesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.enginesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("enginesBindingNavigatorSaveItem.Image")));
            this.enginesBindingNavigatorSaveItem.Name = "enginesBindingNavigatorSaveItem";
            this.enginesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.enginesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.enginesBindingNavigatorSaveItem.Click += new System.EventHandler(this.enginesBindingNavigatorSaveItem_Click_1);
            // 
            // enginesDataGridView
            // 
            this.enginesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enginesDataGridView.AutoGenerateColumns = false;
            this.enginesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.enginesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enginesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1});
            this.enginesDataGridView.DataSource = this.enginesBindingSource;
            this.enginesDataGridView.Location = new System.Drawing.Point(345, 37);
            this.enginesDataGridView.Name = "enginesDataGridView";
            this.enginesDataGridView.Size = new System.Drawing.Size(541, 524);
            this.enginesDataGridView.TabIndex = 1;
            // 
            // наименование_средстваLabel
            // 
            наименование_средстваLabel.AutoSize = true;
            наименование_средстваLabel.Location = new System.Drawing.Point(12, 97);
            наименование_средстваLabel.Name = "наименование_средстваLabel";
            наименование_средстваLabel.Size = new System.Drawing.Size(136, 13);
            наименование_средстваLabel.TabIndex = 4;
            наименование_средстваLabel.Text = "Наименование средства:";
            // 
            // наименование_средстваTextBox
            // 
            this.наименование_средстваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enginesBindingSource, "Наименование средства", true));
            this.наименование_средстваTextBox.Location = new System.Drawing.Point(235, 94);
            this.наименование_средстваTextBox.Name = "наименование_средстваTextBox";
            this.наименование_средстваTextBox.Size = new System.Drawing.Size(104, 20);
            this.наименование_средстваTextBox.TabIndex = 5;
            // 
            // скорость_движения__км_чLabel
            // 
            скорость_движения__км_чLabel.AutoSize = true;
            скорость_движения__км_чLabel.Location = new System.Drawing.Point(12, 123);
            скорость_движения__км_чLabel.Name = "скорость_движения__км_чLabel";
            скорость_движения__км_чLabel.Size = new System.Drawing.Size(141, 13);
            скорость_движения__км_чLabel.TabIndex = 6;
            скорость_движения__км_чLabel.Text = "Скорость движения, км/ч:";
            // 
            // скорость_движения__км_чTextBox
            // 
            this.скорость_движения__км_чTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enginesBindingSource, "Скорость движения, км/ч", true));
            this.скорость_движения__км_чTextBox.Location = new System.Drawing.Point(235, 120);
            this.скорость_движения__км_чTextBox.Name = "скорость_движения__км_чTextBox";
            this.скорость_движения__км_чTextBox.Size = new System.Drawing.Size(104, 20);
            this.скорость_движения__км_чTextBox.TabIndex = 7;
            // 
            // время__необходимое_на_погрузку__минLabel
            // 
            время__необходимое_на_погрузку__минLabel.AutoSize = true;
            время__необходимое_на_погрузку__минLabel.Location = new System.Drawing.Point(12, 149);
            время__необходимое_на_погрузку__минLabel.Name = "время__необходимое_на_погрузку__минLabel";
            время__необходимое_на_погрузку__минLabel.Size = new System.Drawing.Size(205, 13);
            время__необходимое_на_погрузку__минLabel.TabIndex = 8;
            время__необходимое_на_погрузку__минLabel.Text = "Время, необходимое на погрузку, мин:";
            // 
            // время__необходимое_на_погрузку__минTextBox
            // 
            this.время__необходимое_на_погрузку__минTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enginesBindingSource, "Время, необходимое на погрузку, мин", true));
            this.время__необходимое_на_погрузку__минTextBox.Location = new System.Drawing.Point(235, 146);
            this.время__необходимое_на_погрузку__минTextBox.Name = "время__необходимое_на_погрузку__минTextBox";
            this.время__необходимое_на_погрузку__минTextBox.Size = new System.Drawing.Size(104, 20);
            this.время__необходимое_на_погрузку__минTextBox.TabIndex = 9;
            // 
            // возможность_перевозки_эвакуируемого_населения_за_1_рейс__челLabel
            // 
            возможность_перевозки_эвакуируемого_населения_за_1_рейс__челLabel.Location = new System.Drawing.Point(12, 175);
            возможность_перевозки_эвакуируемого_населения_за_1_рейс__челLabel.Name = "возможность_перевозки_эвакуируемого_населения_за_1_рейс__челLabel";
            возможность_перевозки_эвакуируемого_населения_за_1_рейс__челLabel.Size = new System.Drawing.Size(217, 28);
            возможность_перевозки_эвакуируемого_населения_за_1_рейс__челLabel.TabIndex = 10;
            возможность_перевозки_эвакуируемого_населения_за_1_рейс__челLabel.Text = "Возможность перевозки эвакуируемого населения за 1 рейс, чел:";
            // 
            // возможность_перевозки_эвакуируемого_населения_за_1_рейс__челTextBox
            // 
            this.возможность_перевозки_эвакуируемого_населения_за_1_рейс__челTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enginesBindingSource, "Возможность перевозки эвакуируемого населения за 1 рейс, чел", true));
            this.возможность_перевозки_эвакуируемого_населения_за_1_рейс__челTextBox.Location = new System.Drawing.Point(235, 172);
            this.возможность_перевозки_эвакуируемого_населения_за_1_рейс__челTextBox.Name = "возможность_перевозки_эвакуируемого_населения_за_1_рейс__челTextBox";
            this.возможность_перевозки_эвакуируемого_населения_за_1_рейс__челTextBox.Size = new System.Drawing.Size(104, 20);
            this.возможность_перевозки_эвакуируемого_населения_за_1_рейс__челTextBox.TabIndex = 11;
            // 
            // влияние_течения_в_затопленной_областиLabel
            // 
            влияние_течения_в_затопленной_областиLabel.AutoSize = true;
            влияние_течения_в_затопленной_областиLabel.Location = new System.Drawing.Point(12, 211);
            влияние_течения_в_затопленной_областиLabel.Name = "влияние_течения_в_затопленной_областиLabel";
            влияние_течения_в_затопленной_областиLabel.Size = new System.Drawing.Size(217, 13);
            влияние_течения_в_затопленной_областиLabel.TabIndex = 12;
            влияние_течения_в_затопленной_областиLabel.Text = "Влияние течения в затопленной области:";
            // 
            // влияние_течения_в_затопленной_областиCheckBox
            // 
            this.влияние_течения_в_затопленной_областиCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.enginesBindingSource, "Влияние течения в затопленной области", true));
            this.влияние_течения_в_затопленной_областиCheckBox.Location = new System.Drawing.Point(235, 206);
            this.влияние_течения_в_затопленной_областиCheckBox.Name = "влияние_течения_в_затопленной_областиCheckBox";
            this.влияние_течения_в_затопленной_областиCheckBox.Size = new System.Drawing.Size(104, 24);
            this.влияние_течения_в_затопленной_областиCheckBox.TabIndex = 13;
            this.влияние_течения_в_затопленной_областиCheckBox.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование средства";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование средства";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Скорость движения, км/ч";
            this.dataGridViewTextBoxColumn4.HeaderText = "Скорость движения, км/ч";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Время, необходимое на погрузку, мин";
            this.dataGridViewTextBoxColumn5.HeaderText = "Время, необходимое на погрузку, мин";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Возможность перевозки эвакуируемого населения за 1 рейс, чел";
            this.dataGridViewTextBoxColumn6.HeaderText = "Возможность перевозки эвакуируемого населения за 1 рейс, чел";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Влияние течения в затопленной области";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Влияние течения в затопленной области";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 573);
            this.Controls.Add(наименование_средстваLabel);
            this.Controls.Add(this.наименование_средстваTextBox);
            this.Controls.Add(скорость_движения__км_чLabel);
            this.Controls.Add(this.скорость_движения__км_чTextBox);
            this.Controls.Add(время__необходимое_на_погрузку__минLabel);
            this.Controls.Add(this.время__необходимое_на_погрузку__минTextBox);
            this.Controls.Add(возможность_перевозки_эвакуируемого_населения_за_1_рейс__челLabel);
            this.Controls.Add(this.возможность_перевозки_эвакуируемого_населения_за_1_рейс__челTextBox);
            this.Controls.Add(влияние_течения_в_затопленной_областиLabel);
            this.Controls.Add(this.влияние_течения_в_затопленной_областиCheckBox);
            this.Controls.Add(this.enginesDataGridView);
            this.Controls.Add(this.enginesBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enginesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enginesBindingNavigator)).EndInit();
            this.enginesBindingNavigator.ResumeLayout(false);
            this.enginesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enginesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource enginesBindingSource;
        private Database1DataSetTableAdapters.EnginesTableAdapter enginesTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator enginesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton enginesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView enginesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox наименование_средстваTextBox;
        private System.Windows.Forms.TextBox скорость_движения__км_чTextBox;
        private System.Windows.Forms.TextBox время__необходимое_на_погрузку__минTextBox;
        private System.Windows.Forms.TextBox возможность_перевозки_эвакуируемого_населения_за_1_рейс__челTextBox;
        private System.Windows.Forms.CheckBox влияние_течения_в_затопленной_областиCheckBox;
    }
}