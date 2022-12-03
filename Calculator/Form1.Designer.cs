using System;

namespace Calculator 
{
    partial class Form1 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.but4 = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.but0 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.butDot = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.butCE = new System.Windows.Forms.Button();
            this.butC = new System.Windows.Forms.Button();
            this.butPlus = new System.Windows.Forms.Button();
            this.buttonPlusMin = new System.Windows.Forms.Button();
            this.butLn = new System.Windows.Forms.Button();
            this.butEquals = new System.Windows.Forms.Button();
            this.butMinus = new System.Windows.Forms.Button();
            this.butMultiply = new System.Windows.Forms.Button();
            this.butDivide = new System.Windows.Forms.Button();
            this.butPercent = new System.Windows.Forms.Button();
            this.butSqrt = new System.Windows.Forms.Button();
            this.butFact = new System.Windows.Forms.Button();
            this.butDiv1 = new System.Windows.Forms.Button();
            this.butSin = new System.Windows.Forms.Button();
            this.butCos = new System.Windows.Forms.Button();
            this.butTan = new System.Windows.Forms.Button();
            this.butCTG = new System.Windows.Forms.Button();
            this.butEPow = new System.Windows.Forms.Button();
            this.butXPowY = new System.Windows.Forms.Button();
            this.butPow2 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // but4
            // 
            this.but4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but4.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but4.Location = new System.Drawing.Point(9, 271);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(63, 63);
            this.but4.TabIndex = 3;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = true;
            this.but4.Click += new System.EventHandler(this.onNumClick);
            // 
            // but1
            // 
            this.but1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but1.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but1.Location = new System.Drawing.Point(9, 340);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(63, 63);
            this.but1.TabIndex = 4;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.onNumClick);
            // 
            // but0
            // 
            this.but0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but0.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but0.Location = new System.Drawing.Point(9, 409);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(132, 63);
            this.but0.TabIndex = 5;
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = true;
            this.but0.Click += new System.EventHandler(this.onNumClick);
            // 
            // but2
            // 
            this.but2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but2.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but2.Location = new System.Drawing.Point(78, 340);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(63, 63);
            this.but2.TabIndex = 6;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.onNumClick);
            // 
            // but3
            // 
            this.but3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but3.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but3.Location = new System.Drawing.Point(147, 340);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(63, 63);
            this.but3.TabIndex = 7;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.onNumClick);
            // 
            // butDot
            // 
            this.butDot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butDot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butDot.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDot.Location = new System.Drawing.Point(147, 409);
            this.butDot.Name = "butDot";
            this.butDot.Size = new System.Drawing.Size(63, 63);
            this.butDot.TabIndex = 8;
            this.butDot.Text = ",";
            this.butDot.UseVisualStyleBackColor = true;
            this.butDot.Click += new System.EventHandler(this.onNumClick);
            // 
            // but5
            // 
            this.but5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but5.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but5.Location = new System.Drawing.Point(78, 271);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(63, 63);
            this.but5.TabIndex = 9;
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = true;
            this.but5.Click += new System.EventHandler(this.onNumClick);
            // 
            // but6
            // 
            this.but6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but6.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but6.Location = new System.Drawing.Point(147, 271);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(63, 63);
            this.but6.TabIndex = 10;
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = true;
            this.but6.Click += new System.EventHandler(this.onNumClick);
            // 
            // but7
            // 
            this.but7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but7.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but7.Location = new System.Drawing.Point(9, 202);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(63, 63);
            this.but7.TabIndex = 11;
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = true;
            this.but7.Click += new System.EventHandler(this.onNumClick);
            // 
            // but8
            // 
            this.but8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but8.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but8.Location = new System.Drawing.Point(78, 202);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(63, 63);
            this.but8.TabIndex = 12;
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = true;
            this.but8.Click += new System.EventHandler(this.onNumClick);
            // 
            // but9
            // 
            this.but9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but9.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but9.Location = new System.Drawing.Point(147, 202);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(63, 63);
            this.but9.TabIndex = 13;
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = true;
            this.but9.Click += new System.EventHandler(this.onNumClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 63);
            this.button1.TabIndex = 14;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onBackspaceClick);
            // 
            // butCE
            // 
            this.butCE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butCE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butCE.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCE.Location = new System.Drawing.Point(78, 133);
            this.butCE.Name = "butCE";
            this.butCE.Size = new System.Drawing.Size(63, 63);
            this.butCE.TabIndex = 15;
            this.butCE.Text = "CE";
            this.butCE.UseVisualStyleBackColor = true;
            this.butCE.Click += new System.EventHandler(this.butCE_Click);
            // 
            // butC
            // 
            this.butC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butC.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butC.Location = new System.Drawing.Point(147, 133);
            this.butC.Name = "butC";
            this.butC.Size = new System.Drawing.Size(63, 63);
            this.butC.TabIndex = 16;
            this.butC.Text = "C";
            this.butC.UseVisualStyleBackColor = true;
            this.butC.Click += new System.EventHandler(this.butC_Click);
            // 
            // butPlus
            // 
            this.butPlus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butPlus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butPlus.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPlus.Location = new System.Drawing.Point(216, 409);
            this.butPlus.Name = "butPlus";
            this.butPlus.Size = new System.Drawing.Size(63, 63);
            this.butPlus.TabIndex = 17;
            this.butPlus.Text = "+";
            this.butPlus.UseVisualStyleBackColor = true;
            this.butPlus.Click += new System.EventHandler(this.onSimpleOperation);
            // 
            // buttonPlusMin
            // 
            this.buttonPlusMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlusMin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPlusMin.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlusMin.Location = new System.Drawing.Point(285, 409);
            this.buttonPlusMin.Name = "buttonPlusMin";
            this.buttonPlusMin.Size = new System.Drawing.Size(63, 63);
            this.buttonPlusMin.TabIndex = 18;
            this.buttonPlusMin.Text = "+-";
            this.buttonPlusMin.UseVisualStyleBackColor = true;
            this.buttonPlusMin.Click += new System.EventHandler(this.buttonPlusMin_Click);
            // 
            // butLn
            // 
            this.butLn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butLn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butLn.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLn.Location = new System.Drawing.Point(354, 409);
            this.butLn.Name = "butLn";
            this.butLn.Size = new System.Drawing.Size(63, 63);
            this.butLn.TabIndex = 19;
            this.butLn.Text = "ln";
            this.butLn.UseVisualStyleBackColor = true;
            this.butLn.Click += new System.EventHandler(this.butLn_Click);
            // 
            // butEquals
            // 
            this.butEquals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butEquals.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butEquals.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEquals.Location = new System.Drawing.Point(423, 340);
            this.butEquals.Name = "butEquals";
            this.butEquals.Size = new System.Drawing.Size(63, 132);
            this.butEquals.TabIndex = 20;
            this.butEquals.Text = "=";
            this.butEquals.UseVisualStyleBackColor = true;
            this.butEquals.Click += new System.EventHandler(this.butEquals_Click);
            // 
            // butMinus
            // 
            this.butMinus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butMinus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butMinus.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMinus.Location = new System.Drawing.Point(216, 340);
            this.butMinus.Name = "butMinus";
            this.butMinus.Size = new System.Drawing.Size(63, 63);
            this.butMinus.TabIndex = 21;
            this.butMinus.Text = "-";
            this.butMinus.UseVisualStyleBackColor = true;
            this.butMinus.Click += new System.EventHandler(this.onSimpleOperation);
            // 
            // butMultiply
            // 
            this.butMultiply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butMultiply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butMultiply.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMultiply.Location = new System.Drawing.Point(216, 271);
            this.butMultiply.Name = "butMultiply";
            this.butMultiply.Size = new System.Drawing.Size(63, 63);
            this.butMultiply.TabIndex = 22;
            this.butMultiply.Text = "*";
            this.butMultiply.UseVisualStyleBackColor = true;
            this.butMultiply.Click += new System.EventHandler(this.onSimpleOperation);
            // 
            // butDivide
            // 
            this.butDivide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butDivide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butDivide.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDivide.Location = new System.Drawing.Point(216, 202);
            this.butDivide.Name = "butDivide";
            this.butDivide.Size = new System.Drawing.Size(63, 63);
            this.butDivide.TabIndex = 23;
            this.butDivide.Text = "/";
            this.butDivide.UseVisualStyleBackColor = true;
            this.butDivide.Click += new System.EventHandler(this.onSimpleOperation);
            // 
            // butPercent
            // 
            this.butPercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butPercent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butPercent.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPercent.Location = new System.Drawing.Point(216, 133);
            this.butPercent.Name = "butPercent";
            this.butPercent.Size = new System.Drawing.Size(63, 63);
            this.butPercent.TabIndex = 24;
            this.butPercent.Text = "%";
            this.butPercent.UseVisualStyleBackColor = true;
            this.butPercent.Click += new System.EventHandler(this.onSimpleOperation);
            // 
            // butSqrt
            // 
            this.butSqrt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butSqrt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butSqrt.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSqrt.Location = new System.Drawing.Point(285, 340);
            this.butSqrt.Name = "butSqrt";
            this.butSqrt.Size = new System.Drawing.Size(63, 63);
            this.butSqrt.TabIndex = 25;
            this.butSqrt.Text = "√";
            this.butSqrt.UseVisualStyleBackColor = true;
            this.butSqrt.Click += new System.EventHandler(this.butSqrt_Click);
            // 
            // butFact
            // 
            this.butFact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butFact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butFact.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFact.Location = new System.Drawing.Point(354, 340);
            this.butFact.Name = "butFact";
            this.butFact.Size = new System.Drawing.Size(63, 63);
            this.butFact.TabIndex = 26;
            this.butFact.Text = "!";
            this.butFact.UseVisualStyleBackColor = true;
            this.butFact.Click += new System.EventHandler(this.butFact_Click);
            // 
            // butDiv1
            // 
            this.butDiv1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butDiv1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butDiv1.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDiv1.Location = new System.Drawing.Point(285, 133);
            this.butDiv1.Name = "butDiv1";
            this.butDiv1.Size = new System.Drawing.Size(132, 63);
            this.butDiv1.TabIndex = 27;
            this.butDiv1.Text = "1/x";
            this.butDiv1.UseVisualStyleBackColor = true;
            this.butDiv1.Click += new System.EventHandler(this.butDiv1_Click);
            // 
            // butSin
            // 
            this.butSin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butSin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butSin.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSin.Location = new System.Drawing.Point(285, 271);
            this.butSin.Name = "butSin";
            this.butSin.Size = new System.Drawing.Size(63, 63);
            this.butSin.TabIndex = 28;
            this.butSin.Text = "sin";
            this.butSin.UseVisualStyleBackColor = true;
            this.butSin.Click += new System.EventHandler(this.butSin_Click);
            // 
            // butCos
            // 
            this.butCos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butCos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butCos.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCos.Location = new System.Drawing.Point(354, 271);
            this.butCos.Name = "butCos";
            this.butCos.Size = new System.Drawing.Size(63, 63);
            this.butCos.TabIndex = 29;
            this.butCos.Text = "cos";
            this.butCos.UseVisualStyleBackColor = true;
            this.butCos.Click += new System.EventHandler(this.butCos_Click);
            // 
            // butTan
            // 
            this.butTan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butTan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butTan.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTan.Location = new System.Drawing.Point(285, 202);
            this.butTan.Name = "butTan";
            this.butTan.Size = new System.Drawing.Size(63, 63);
            this.butTan.TabIndex = 30;
            this.butTan.Text = "tan";
            this.butTan.UseVisualStyleBackColor = true;
            this.butTan.Click += new System.EventHandler(this.butTan_Click);
            // 
            // butCTG
            // 
            this.butCTG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butCTG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butCTG.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCTG.Location = new System.Drawing.Point(354, 202);
            this.butCTG.Name = "butCTG";
            this.butCTG.Size = new System.Drawing.Size(63, 63);
            this.butCTG.TabIndex = 31;
            this.butCTG.Text = "ctg";
            this.butCTG.UseVisualStyleBackColor = true;
            this.butCTG.Click += new System.EventHandler(this.butCTG_Click);
            // 
            // butEPow
            // 
            this.butEPow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butEPow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butEPow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butEPow.BackgroundImage")));
            this.butEPow.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEPow.Location = new System.Drawing.Point(423, 271);
            this.butEPow.Name = "butEPow";
            this.butEPow.Size = new System.Drawing.Size(63, 63);
            this.butEPow.TabIndex = 32;
            this.butEPow.UseVisualStyleBackColor = true;
            this.butEPow.Click += new System.EventHandler(this.butEPow_Click);
            // 
            // butXPowY
            // 
            this.butXPowY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butXPowY.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butXPowY.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butXPowY.BackgroundImage")));
            this.butXPowY.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXPowY.Location = new System.Drawing.Point(423, 202);
            this.butXPowY.Name = "butXPowY";
            this.butXPowY.Size = new System.Drawing.Size(63, 63);
            this.butXPowY.TabIndex = 33;
            this.butXPowY.Tag = "";
            this.butXPowY.Text = " ";
            this.butXPowY.UseVisualStyleBackColor = true;
            this.butXPowY.Click += new System.EventHandler(this.onSimpleOperation);
            // 
            // butPow2
            // 
            this.butPow2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butPow2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butPow2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butPow2.BackgroundImage")));
            this.butPow2.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPow2.Location = new System.Drawing.Point(423, 133);
            this.butPow2.Name = "butPow2";
            this.butPow2.Size = new System.Drawing.Size(63, 63);
            this.butPow2.TabIndex = 34;
            this.butPow2.UseVisualStyleBackColor = true;
            this.butPow2.Click += new System.EventHandler(this.butPow2_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(9, 64);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(477, 56);
            this.textBox.TabIndex = 35;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(8, 21);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 35);
            this.label.TabIndex = 36;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(5, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 28);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(494, 480);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.butPow2);
            this.Controls.Add(this.butXPowY);
            this.Controls.Add(this.butEPow);
            this.Controls.Add(this.butCTG);
            this.Controls.Add(this.butTan);
            this.Controls.Add(this.butCos);
            this.Controls.Add(this.butSin);
            this.Controls.Add(this.butDiv1);
            this.Controls.Add(this.butFact);
            this.Controls.Add(this.butSqrt);
            this.Controls.Add(this.butPercent);
            this.Controls.Add(this.butDivide);
            this.Controls.Add(this.butMultiply);
            this.Controls.Add(this.butMinus);
            this.Controls.Add(this.butEquals);
            this.Controls.Add(this.butLn);
            this.Controls.Add(this.buttonPlusMin);
            this.Controls.Add(this.butPlus);
            this.Controls.Add(this.butC);
            this.Controls.Add(this.butCE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but9);
            this.Controls.Add(this.but8);
            this.Controls.Add(this.but7);
            this.Controls.Add(this.but6);
            this.Controls.Add(this.but5);
            this.Controls.Add(this.butDot);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but0);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.but4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void onNumClink(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but0;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button butDot;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butCE;
        private System.Windows.Forms.Button butC;
        private System.Windows.Forms.Button butPlus;
        private System.Windows.Forms.Button buttonPlusMin;
        private System.Windows.Forms.Button butLn;
        private System.Windows.Forms.Button butEquals;
        private System.Windows.Forms.Button butMinus;
        private System.Windows.Forms.Button butMultiply;
        private System.Windows.Forms.Button butDivide;
        private System.Windows.Forms.Button butPercent;
        private System.Windows.Forms.Button butSqrt;
        private System.Windows.Forms.Button butFact;
        private System.Windows.Forms.Button butDiv1;
        private System.Windows.Forms.Button butSin;
        private System.Windows.Forms.Button butCos;
        private System.Windows.Forms.Button butTan;
        private System.Windows.Forms.Button butCTG;
        private System.Windows.Forms.Button butEPow;
        private System.Windows.Forms.Button butXPowY;
        private System.Windows.Forms.Button butPow2;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

