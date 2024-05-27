
namespace ITAP3010_Group_Assignment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.autoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdateInventory = new System.Windows.Forms.Button();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.btnApplyDiscount = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnColdDrinks = new System.Windows.Forms.Button();
            this.btnCalamari = new System.Windows.Forms.Button();
            this.btnChickenWings = new System.Windows.Forms.Button();
            this.btnKebab = new System.Windows.Forms.Button();
            this.btnGarlicBread = new System.Windows.Forms.Button();
            this.btnMilkshake = new System.Windows.Forms.Button();
            this.btnFishAndChips = new System.Windows.Forms.Button();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnBolognese = new System.Windows.Forms.Button();
            this.btnTacos = new System.Windows.Forms.Button();
            this.btnChips = new System.Windows.Forms.Button();
            this.btnBeefBurger = new System.Windows.Forms.Button();
            this.btnChickenBurger = new System.Windows.Forms.Button();
            this.btnTea = new System.Windows.Forms.Button();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 585);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnUpdateInventory);
            this.panel2.Controls.Add(this.btnProcessPayment);
            this.panel2.Controls.Add(this.btnApplyDiscount);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.btnColdDrinks);
            this.panel2.Controls.Add(this.btnCalamari);
            this.panel2.Controls.Add(this.btnChickenWings);
            this.panel2.Controls.Add(this.btnKebab);
            this.panel2.Controls.Add(this.btnGarlicBread);
            this.panel2.Controls.Add(this.btnMilkshake);
            this.panel2.Controls.Add(this.btnFishAndChips);
            this.panel2.Controls.Add(this.btnPizza);
            this.panel2.Controls.Add(this.btnBolognese);
            this.panel2.Controls.Add(this.btnTacos);
            this.panel2.Controls.Add(this.btnChips);
            this.panel2.Controls.Add(this.btnBeefBurger);
            this.panel2.Controls.Add(this.btnChickenBurger);
            this.panel2.Controls.Add(this.btnTea);
            this.panel2.Controls.Add(this.btnCoffee);
            this.panel2.Location = new System.Drawing.Point(567, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 585);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoid,
            this.Name,
            this.Quantity,
            this.Price});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 585);
            this.dataGridView1.TabIndex = 0;
            // 
            // autoid
            // 
            this.autoid.HeaderText = "";
            this.autoid.Name = "autoid";
            this.autoid.Visible = false;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Name.DefaultCellStyle = dataGridViewCellStyle4;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.Width = 60;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Qunatity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(401, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(127, 43);
            this.panel4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "0.00 $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Sales : (Cash)";
            // 
            // btnUpdateInventory
            // 
            this.btnUpdateInventory.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnUpdateInventory.Location = new System.Drawing.Point(242, 473);
            this.btnUpdateInventory.Name = "btnUpdateInventory";
            this.btnUpdateInventory.Size = new System.Drawing.Size(202, 53);
            this.btnUpdateInventory.TabIndex = 55;
            this.btnUpdateInventory.Text = "Update Inventory";
            this.btnUpdateInventory.UseVisualStyleBackColor = false;
            // 
            // btnProcessPayment
            // 
            this.btnProcessPayment.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnProcessPayment.Location = new System.Drawing.Point(21, 473);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(202, 53);
            this.btnProcessPayment.TabIndex = 54;
            this.btnProcessPayment.Text = "Process Payment";
            this.btnProcessPayment.UseVisualStyleBackColor = false;
            // 
            // btnApplyDiscount
            // 
            this.btnApplyDiscount.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnApplyDiscount.Location = new System.Drawing.Point(242, 414);
            this.btnApplyDiscount.Name = "btnApplyDiscount";
            this.btnApplyDiscount.Size = new System.Drawing.Size(202, 53);
            this.btnApplyDiscount.TabIndex = 53;
            this.btnApplyDiscount.Text = "Apply Discount";
            this.btnApplyDiscount.UseVisualStyleBackColor = false;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSend.Location = new System.Drawing.Point(21, 414);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(202, 53);
            this.btnSend.TabIndex = 52;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GrayText;
            this.button6.Location = new System.Drawing.Point(306, 344);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 53);
            this.button6.TabIndex = 51;
            this.button6.Text = "Cold Drinks";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GrayText;
            this.button7.Location = new System.Drawing.Point(211, 344);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 53);
            this.button7.TabIndex = 50;
            this.button7.Text = "Cold Drinks";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.GrayText;
            this.button8.Location = new System.Drawing.Point(116, 344);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 53);
            this.button8.TabIndex = 49;
            this.button8.Text = "Calamari";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.GrayText;
            this.button9.Location = new System.Drawing.Point(21, 344);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 53);
            this.button9.TabIndex = 48;
            this.button9.Text = "Chicken WIngs";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Location = new System.Drawing.Point(306, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 53);
            this.button1.TabIndex = 47;
            this.button1.Text = "Cold Drinks";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Location = new System.Drawing.Point(306, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 53);
            this.button2.TabIndex = 46;
            this.button2.Text = "Kebab";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.Location = new System.Drawing.Point(306, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 53);
            this.button3.TabIndex = 45;
            this.button3.Text = "Fish And Chips";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GrayText;
            this.button4.Location = new System.Drawing.Point(306, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 53);
            this.button4.TabIndex = 44;
            this.button4.Text = "Tacos";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GrayText;
            this.button5.Location = new System.Drawing.Point(306, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 53);
            this.button5.TabIndex = 43;
            this.button5.Text = "Chicken Burger";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnColdDrinks
            // 
            this.btnColdDrinks.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnColdDrinks.Location = new System.Drawing.Point(211, 276);
            this.btnColdDrinks.Name = "btnColdDrinks";
            this.btnColdDrinks.Size = new System.Drawing.Size(89, 53);
            this.btnColdDrinks.TabIndex = 42;
            this.btnColdDrinks.Text = "Cold Drinks";
            this.btnColdDrinks.UseVisualStyleBackColor = false;
            // 
            // btnCalamari
            // 
            this.btnCalamari.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnCalamari.Location = new System.Drawing.Point(116, 276);
            this.btnCalamari.Name = "btnCalamari";
            this.btnCalamari.Size = new System.Drawing.Size(89, 53);
            this.btnCalamari.TabIndex = 41;
            this.btnCalamari.Text = "Calamari";
            this.btnCalamari.UseVisualStyleBackColor = false;
            // 
            // btnChickenWings
            // 
            this.btnChickenWings.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnChickenWings.Location = new System.Drawing.Point(21, 276);
            this.btnChickenWings.Name = "btnChickenWings";
            this.btnChickenWings.Size = new System.Drawing.Size(89, 53);
            this.btnChickenWings.TabIndex = 40;
            this.btnChickenWings.Text = "Chicken WIngs";
            this.btnChickenWings.UseVisualStyleBackColor = false;
            // 
            // btnKebab
            // 
            this.btnKebab.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnKebab.Location = new System.Drawing.Point(211, 213);
            this.btnKebab.Name = "btnKebab";
            this.btnKebab.Size = new System.Drawing.Size(89, 53);
            this.btnKebab.TabIndex = 39;
            this.btnKebab.Text = "Kebab";
            this.btnKebab.UseVisualStyleBackColor = false;
            // 
            // btnGarlicBread
            // 
            this.btnGarlicBread.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnGarlicBread.Location = new System.Drawing.Point(116, 213);
            this.btnGarlicBread.Name = "btnGarlicBread";
            this.btnGarlicBread.Size = new System.Drawing.Size(89, 53);
            this.btnGarlicBread.TabIndex = 38;
            this.btnGarlicBread.Text = "Garlic Bread";
            this.btnGarlicBread.UseVisualStyleBackColor = false;
            // 
            // btnMilkshake
            // 
            this.btnMilkshake.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnMilkshake.Location = new System.Drawing.Point(21, 213);
            this.btnMilkshake.Name = "btnMilkshake";
            this.btnMilkshake.Size = new System.Drawing.Size(89, 53);
            this.btnMilkshake.TabIndex = 37;
            this.btnMilkshake.Text = "Milkshake";
            this.btnMilkshake.UseVisualStyleBackColor = false;
            // 
            // btnFishAndChips
            // 
            this.btnFishAndChips.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnFishAndChips.Location = new System.Drawing.Point(211, 147);
            this.btnFishAndChips.Name = "btnFishAndChips";
            this.btnFishAndChips.Size = new System.Drawing.Size(89, 53);
            this.btnFishAndChips.TabIndex = 36;
            this.btnFishAndChips.Text = "Fish And Chips";
            this.btnFishAndChips.UseVisualStyleBackColor = false;
            // 
            // btnPizza
            // 
            this.btnPizza.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnPizza.Location = new System.Drawing.Point(116, 147);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(89, 53);
            this.btnPizza.TabIndex = 35;
            this.btnPizza.Text = "Pizza";
            this.btnPizza.UseVisualStyleBackColor = false;
            // 
            // btnBolognese
            // 
            this.btnBolognese.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnBolognese.Location = new System.Drawing.Point(21, 148);
            this.btnBolognese.Name = "btnBolognese";
            this.btnBolognese.Size = new System.Drawing.Size(89, 53);
            this.btnBolognese.TabIndex = 34;
            this.btnBolognese.Text = "Bolognese";
            this.btnBolognese.UseVisualStyleBackColor = false;
            // 
            // btnTacos
            // 
            this.btnTacos.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnTacos.Location = new System.Drawing.Point(211, 79);
            this.btnTacos.Name = "btnTacos";
            this.btnTacos.Size = new System.Drawing.Size(89, 53);
            this.btnTacos.TabIndex = 33;
            this.btnTacos.Text = "Tacos";
            this.btnTacos.UseVisualStyleBackColor = false;
            // 
            // btnChips
            // 
            this.btnChips.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnChips.Location = new System.Drawing.Point(116, 79);
            this.btnChips.Name = "btnChips";
            this.btnChips.Size = new System.Drawing.Size(89, 53);
            this.btnChips.TabIndex = 32;
            this.btnChips.Text = "Chips";
            this.btnChips.UseVisualStyleBackColor = false;
            // 
            // btnBeefBurger
            // 
            this.btnBeefBurger.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnBeefBurger.Location = new System.Drawing.Point(21, 79);
            this.btnBeefBurger.Name = "btnBeefBurger";
            this.btnBeefBurger.Size = new System.Drawing.Size(89, 53);
            this.btnBeefBurger.TabIndex = 31;
            this.btnBeefBurger.Text = "Beef Burger";
            this.btnBeefBurger.UseVisualStyleBackColor = false;
            // 
            // btnChickenBurger
            // 
            this.btnChickenBurger.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnChickenBurger.Location = new System.Drawing.Point(211, 14);
            this.btnChickenBurger.Name = "btnChickenBurger";
            this.btnChickenBurger.Size = new System.Drawing.Size(89, 53);
            this.btnChickenBurger.TabIndex = 30;
            this.btnChickenBurger.Text = "Chicken Burger";
            this.btnChickenBurger.UseVisualStyleBackColor = false;
            // 
            // btnTea
            // 
            this.btnTea.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnTea.Location = new System.Drawing.Point(116, 14);
            this.btnTea.Name = "btnTea";
            this.btnTea.Size = new System.Drawing.Size(89, 53);
            this.btnTea.TabIndex = 29;
            this.btnTea.Text = "Tea";
            this.btnTea.UseVisualStyleBackColor = false;
            // 
            // btnCoffee
            // 
            this.btnCoffee.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnCoffee.Location = new System.Drawing.Point(21, 14);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(89, 53);
            this.btnCoffee.TabIndex = 28;
            this.btnCoffee.Text = "Coffee";
            this.btnCoffee.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(401, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 43);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "0.00 $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Sales : (Card)";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(401, 230);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(127, 43);
            this.panel5.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "0.00 $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Sales : (Overall)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 618);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateInventory;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.Button btnApplyDiscount;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnColdDrinks;
        private System.Windows.Forms.Button btnCalamari;
        private System.Windows.Forms.Button btnChickenWings;
        private System.Windows.Forms.Button btnKebab;
        private System.Windows.Forms.Button btnGarlicBread;
        private System.Windows.Forms.Button btnMilkshake;
        private System.Windows.Forms.Button btnFishAndChips;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnBolognese;
        private System.Windows.Forms.Button btnTacos;
        private System.Windows.Forms.Button btnChips;
        private System.Windows.Forms.Button btnBeefBurger;
        private System.Windows.Forms.Button btnChickenBurger;
        private System.Windows.Forms.Button btnTea;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}