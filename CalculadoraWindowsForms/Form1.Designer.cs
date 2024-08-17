namespace CalculadoraWindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSoma = new Button();
            btnSub = new Button();
            btnDivi = new Button();
            btnMulti = new Button();
            label3 = new Label();
            btn9 = new Button();
            btn8 = new Button();
            btn0 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn7 = new Button();
            btnAllDelete = new Button();
            btnDelete = new Button();
            btnEqual = new Button();
            btnPoint = new Button();
            ttbView = new TextBox();
            SuspendLayout();
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSoma.Location = new Point(219, 168);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(61, 52);
            btnSoma.TabIndex = 0;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSub.Location = new Point(221, 226);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(59, 52);
            btnSub.TabIndex = 1;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnDivi
            // 
            btnDivi.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivi.Location = new Point(286, 226);
            btnDivi.Name = "btnDivi";
            btnDivi.Size = new Size(61, 52);
            btnDivi.TabIndex = 9;
            btnDivi.Text = "÷";
            btnDivi.UseVisualStyleBackColor = true;
            btnDivi.Click += btnDivi_Click;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMulti.Location = new Point(286, 168);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(61, 52);
            btnMulti.TabIndex = 10;
            btnMulti.Text = "x";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 9);
            label3.Name = "label3";
            label3.Size = new Size(205, 47);
            label3.TabIndex = 15;
            label3.Text = "Calculadora";
            label3.Click += label3_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(12, 110);
            btn9.Name = "btn9";
            btn9.Size = new Size(63, 52);
            btn9.TabIndex = 17;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(81, 110);
            btn8.Name = "btn8";
            btn8.Size = new Size(63, 52);
            btn8.TabIndex = 18;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(14, 284);
            btn0.Name = "btn0";
            btn0.Size = new Size(201, 43);
            btn0.TabIndex = 25;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(14, 168);
            btn6.Name = "btn6";
            btn6.Size = new Size(63, 52);
            btn6.TabIndex = 26;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(83, 168);
            btn5.Name = "btn5";
            btn5.Size = new Size(63, 52);
            btn5.TabIndex = 27;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(150, 168);
            btn4.Name = "btn4";
            btn4.Size = new Size(63, 52);
            btn4.TabIndex = 28;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(152, 226);
            btn1.Name = "btn1";
            btn1.Size = new Size(63, 52);
            btn1.TabIndex = 29;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(83, 226);
            btn2.Name = "btn2";
            btn2.Size = new Size(63, 52);
            btn2.TabIndex = 30;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(14, 226);
            btn3.Name = "btn3";
            btn3.Size = new Size(63, 52);
            btn3.TabIndex = 31;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(150, 110);
            btn7.Name = "btn7";
            btn7.Size = new Size(63, 52);
            btn7.TabIndex = 32;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btnAllDelete
            // 
            btnAllDelete.Location = new Point(219, 110);
            btnAllDelete.Name = "btnAllDelete";
            btnAllDelete.Size = new Size(61, 52);
            btnAllDelete.TabIndex = 33;
            btnAllDelete.Text = "C";
            btnAllDelete.UseVisualStyleBackColor = true;
            btnAllDelete.Click += btnAllDelete_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(286, 110);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(61, 52);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "<-";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(286, 284);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(61, 43);
            btnEqual.TabIndex = 35;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnPoint
            // 
            btnPoint.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPoint.Location = new Point(219, 284);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(61, 43);
            btnPoint.TabIndex = 36;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += btnPoint_Click;
            // 
            // ttbView
            // 
            ttbView.Location = new Point(14, 69);
            ttbView.Name = "ttbView";
            ttbView.Size = new Size(333, 23);
            ttbView.TabIndex = 37;
            ttbView.TextChanged += ttbView_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 348);
            Controls.Add(ttbView);
            Controls.Add(btnPoint);
            Controls.Add(btnEqual);
            Controls.Add(btnDelete);
            Controls.Add(btnAllDelete);
            Controls.Add(btn7);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn0);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(label3);
            Controls.Add(btnMulti);
            Controls.Add(btnDivi);
            Controls.Add(btnSub);
            Controls.Add(btnSoma);
            Name = "Form1";
            Text = "Calculadora Simples";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSoma;
        private Button btnSub;
        private Button btnDivi;
        private Button btnMulti;
        private Label label3;
        private Button btn9;
        private Button btn8;
        private Button btn0;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn7;
        private Button btnAllDelete;
        private Button btnDelete;
        private Button btnEqual;
        private Button btnPoint;
        private TextBox ttbView;
    }
}
