namespace WinFormUI
{
    partial class CreateOrderForm
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
            this.addItemsPanel = new System.Windows.Forms.Panel();
            this.subtotalPriceText = new System.Windows.Forms.TextBox();
            this.quantityPicker = new System.Windows.Forms.NumericUpDown();
            this.paymentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.orderItemList = new System.Windows.Forms.ListBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.fullItemList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.discountsTipsPanel = new System.Windows.Forms.Panel();
            this.applyTipButton = new System.Windows.Forms.Button();
            this.applyDiscountButton = new System.Windows.Forms.Button();
            this.subtotalPriceText2 = new System.Windows.Forms.TextBox();
            this.discountList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tipAmountInputText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.orderReceiptPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.orderItemsListReceipt = new System.Windows.Forms.ListBox();
            this.totalPriceText = new System.Windows.Forms.TextBox();
            this.totalPriceList = new System.Windows.Forms.TextBox();
            this.addItemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityPicker)).BeginInit();
            this.discountsTipsPanel.SuspendLayout();
            this.orderReceiptPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addItemsPanel
            // 
            this.addItemsPanel.Controls.Add(this.subtotalPriceText);
            this.addItemsPanel.Controls.Add(this.quantityPicker);
            this.addItemsPanel.Controls.Add(this.paymentButton);
            this.addItemsPanel.Controls.Add(this.label1);
            this.addItemsPanel.Controls.Add(this.removeItemButton);
            this.addItemsPanel.Controls.Add(this.orderItemList);
            this.addItemsPanel.Controls.Add(this.addItemButton);
            this.addItemsPanel.Controls.Add(this.fullItemList);
            this.addItemsPanel.Controls.Add(this.label2);
            this.addItemsPanel.Location = new System.Drawing.Point(12, 12);
            this.addItemsPanel.Name = "addItemsPanel";
            this.addItemsPanel.Size = new System.Drawing.Size(1191, 439);
            this.addItemsPanel.TabIndex = 14;
            // 
            // subtotalPriceText
            // 
            this.subtotalPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalPriceText.Location = new System.Drawing.Point(590, 409);
            this.subtotalPriceText.Name = "subtotalPriceText";
            this.subtotalPriceText.Size = new System.Drawing.Size(354, 30);
            this.subtotalPriceText.TabIndex = 22;
            this.subtotalPriceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quantityPicker
            // 
            this.quantityPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityPicker.Location = new System.Drawing.Point(518, 196);
            this.quantityPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityPicker.Name = "quantityPicker";
            this.quantityPicker.Size = new System.Drawing.Size(57, 30);
            this.quantityPicker.TabIndex = 21;
            this.quantityPicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // paymentButton
            // 
            this.paymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentButton.Location = new System.Drawing.Point(950, 398);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(241, 41);
            this.paymentButton.TabIndex = 20;
            this.paymentButton.Text = "Move on to payment";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(582, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 46);
            this.label1.TabIndex = 19;
            this.label1.Text = "Order";
            // 
            // removeItemButton
            // 
            this.removeItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItemButton.Location = new System.Drawing.Point(950, 190);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(178, 41);
            this.removeItemButton.TabIndex = 18;
            this.removeItemButton.Text = "Remove item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // orderItemList
            // 
            this.orderItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderItemList.FormattingEnabled = true;
            this.orderItemList.ItemHeight = 25;
            this.orderItemList.Location = new System.Drawing.Point(590, 49);
            this.orderItemList.Name = "orderItemList";
            this.orderItemList.Size = new System.Drawing.Size(354, 354);
            this.orderItemList.TabIndex = 17;
            // 
            // addItemButton
            // 
            this.addItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.Location = new System.Drawing.Point(368, 190);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(144, 41);
            this.addItemButton.TabIndex = 16;
            this.addItemButton.Text = "Add item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // fullItemList
            // 
            this.fullItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullItemList.FormattingEnabled = true;
            this.fullItemList.ItemHeight = 25;
            this.fullItemList.Location = new System.Drawing.Point(8, 49);
            this.fullItemList.Name = "fullItemList";
            this.fullItemList.Size = new System.Drawing.Size(354, 354);
            this.fullItemList.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 46);
            this.label2.TabIndex = 14;
            this.label2.Text = "Item List";
            // 
            // discountsTipsPanel
            // 
            this.discountsTipsPanel.Controls.Add(this.payButton);
            this.discountsTipsPanel.Controls.Add(this.applyTipButton);
            this.discountsTipsPanel.Controls.Add(this.applyDiscountButton);
            this.discountsTipsPanel.Controls.Add(this.subtotalPriceText2);
            this.discountsTipsPanel.Controls.Add(this.discountList);
            this.discountsTipsPanel.Controls.Add(this.label4);
            this.discountsTipsPanel.Controls.Add(this.tipAmountInputText);
            this.discountsTipsPanel.Controls.Add(this.label3);
            this.discountsTipsPanel.Controls.Add(this.tipLabel);
            this.discountsTipsPanel.Controls.Add(this.discountLabel);
            this.discountsTipsPanel.Location = new System.Drawing.Point(20, 12);
            this.discountsTipsPanel.Name = "discountsTipsPanel";
            this.discountsTipsPanel.Size = new System.Drawing.Size(1183, 439);
            this.discountsTipsPanel.TabIndex = 15;
            // 
            // applyTipButton
            // 
            this.applyTipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyTipButton.Location = new System.Drawing.Point(445, 99);
            this.applyTipButton.Name = "applyTipButton";
            this.applyTipButton.Size = new System.Drawing.Size(103, 39);
            this.applyTipButton.TabIndex = 25;
            this.applyTipButton.Text = "Apply";
            this.applyTipButton.UseVisualStyleBackColor = true;
            this.applyTipButton.Click += new System.EventHandler(this.applyTipButton_Click);
            // 
            // applyDiscountButton
            // 
            this.applyDiscountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyDiscountButton.Location = new System.Drawing.Point(445, 42);
            this.applyDiscountButton.Name = "applyDiscountButton";
            this.applyDiscountButton.Size = new System.Drawing.Size(103, 39);
            this.applyDiscountButton.TabIndex = 24;
            this.applyDiscountButton.Text = "Apply";
            this.applyDiscountButton.UseVisualStyleBackColor = true;
            this.applyDiscountButton.Click += new System.EventHandler(this.applyDiscountButton_Click);
            // 
            // subtotalPriceText2
            // 
            this.subtotalPriceText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalPriceText2.Location = new System.Drawing.Point(798, 42);
            this.subtotalPriceText2.Name = "subtotalPriceText2";
            this.subtotalPriceText2.Size = new System.Drawing.Size(354, 30);
            this.subtotalPriceText2.TabIndex = 23;
            this.subtotalPriceText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // discountList
            // 
            this.discountList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discountList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountList.FormattingEnabled = true;
            this.discountList.Location = new System.Drawing.Point(254, 42);
            this.discountList.Name = "discountList";
            this.discountList.Size = new System.Drawing.Size(100, 39);
            this.discountList.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "EUR";
            // 
            // tipAmountInputText
            // 
            this.tipAmountInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipAmountInputText.Location = new System.Drawing.Point(254, 99);
            this.tipAmountInputText.Name = "tipAmountInputText";
            this.tipAmountInputText.Size = new System.Drawing.Size(100, 38);
            this.tipAmountInputText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "%";
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipLabel.Location = new System.Drawing.Point(102, 105);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(130, 32);
            this.tipLabel.TabIndex = 1;
            this.tipLabel.Text = "Leave tip";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.Location = new System.Drawing.Point(53, 49);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(179, 32);
            this.discountLabel.TabIndex = 0;
            this.discountLabel.Text = "Add discount";
            // 
            // payButton
            // 
            this.payButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton.Location = new System.Drawing.Point(957, 387);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(195, 39);
            this.payButton.TabIndex = 26;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // orderReceiptPanel
            // 
            this.orderReceiptPanel.Controls.Add(this.totalPriceList);
            this.orderReceiptPanel.Controls.Add(this.totalPriceText);
            this.orderReceiptPanel.Controls.Add(this.orderItemsListReceipt);
            this.orderReceiptPanel.Controls.Add(this.label5);
            this.orderReceiptPanel.Location = new System.Drawing.Point(12, 12);
            this.orderReceiptPanel.Name = "orderReceiptPanel";
            this.orderReceiptPanel.Size = new System.Drawing.Size(1191, 439);
            this.orderReceiptPanel.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Order receipt";
            // 
            // orderItemsListReceipt
            // 
            this.orderItemsListReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderItemsListReceipt.FormattingEnabled = true;
            this.orderItemsListReceipt.ItemHeight = 25;
            this.orderItemsListReceipt.Location = new System.Drawing.Point(40, 65);
            this.orderItemsListReceipt.Name = "orderItemsListReceipt";
            this.orderItemsListReceipt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orderItemsListReceipt.Size = new System.Drawing.Size(374, 179);
            this.orderItemsListReceipt.TabIndex = 1;
            // 
            // totalPriceText
            // 
            this.totalPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceText.Location = new System.Drawing.Point(196, 373);
            this.totalPriceText.Name = "totalPriceText";
            this.totalPriceText.Size = new System.Drawing.Size(218, 30);
            this.totalPriceText.TabIndex = 3;
            this.totalPriceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalPriceList
            // 
            this.totalPriceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceList.Location = new System.Drawing.Point(41, 253);
            this.totalPriceList.Multiline = true;
            this.totalPriceList.Name = "totalPriceList";
            this.totalPriceList.Size = new System.Drawing.Size(372, 114);
            this.totalPriceList.TabIndex = 4;
            this.totalPriceList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 450);
            this.Controls.Add(this.orderReceiptPanel);
            this.Controls.Add(this.discountsTipsPanel);
            this.Controls.Add(this.addItemsPanel);
            this.Name = "CreateOrderForm";
            this.Text = "CreateOrderForm";
            this.addItemsPanel.ResumeLayout(false);
            this.addItemsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityPicker)).EndInit();
            this.discountsTipsPanel.ResumeLayout(false);
            this.discountsTipsPanel.PerformLayout();
            this.orderReceiptPanel.ResumeLayout(false);
            this.orderReceiptPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addItemsPanel;
        private System.Windows.Forms.TextBox subtotalPriceText;
        private System.Windows.Forms.NumericUpDown quantityPicker;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.ListBox orderItemList;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.ListBox fullItemList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel discountsTipsPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tipAmountInputText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.ComboBox discountList;
        private System.Windows.Forms.TextBox subtotalPriceText2;
        private System.Windows.Forms.Button applyTipButton;
        private System.Windows.Forms.Button applyDiscountButton;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Panel orderReceiptPanel;
        private System.Windows.Forms.TextBox totalPriceText;
        private System.Windows.Forms.ListBox orderItemsListReceipt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalPriceList;
    }
}