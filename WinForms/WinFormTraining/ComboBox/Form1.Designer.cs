namespace ComboBox
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
            this.cb_Crypto = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_ins = new System.Windows.Forms.Button();
            this.tb_add = new System.Windows.Forms.TextBox();
            this.tb_del = new System.Windows.Forms.TextBox();
            this.tb_ins = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_Crypto
            // 
            this.cb_Crypto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Crypto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Crypto.DropDownHeight = 100;
            this.cb_Crypto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_Crypto.FormattingEnabled = true;
            this.cb_Crypto.IntegralHeight = false;
            this.cb_Crypto.Items.AddRange(new object[] {
            "0x",
            "AdEx",
            "Aeternity",
            "Ardor",
            "Ark",
            "ATMChain",
            "Augur",
            "B3Coin",
            "Bancor",
            "Basic Attenti...",
            "Binance Coin",
            "Bitcoin",
            "Bitcoin Cash",
            "BitcoinDark",
            "BitConnect",
            "Bitquence",
            "BitShares",
            "Blocknet",
            "Byteball Bytes",
            "Bytecoin",
            "Bytom",
            "Cardano",
            "ChainLink",
            "Civic",
            "Cryptonex",
            "Dash",
            "Decred",
            "DigiByte",
            "DigixDAO",
            "Dogecoin",
            "Edgeless",
            "Electroneum",
            "EOS",
            "Ethereum",
            "Ethereum Classic",
            "Factom",
            "FairCoin",
            "FunFair",
            "GameCredits",
            "Gas",
            "Gnosis",
            "Golem",
            "GXShares",
            "Hshare",
            "Iconomi",
            "IOTA",
            "Komodo",
            "KuCoin Shares",
            "Kyber Network",
            "Lisk",
            "Litecoin",
            "Lykke",
            "MaidSafeCoin",
            "Metal",
            "Metaverse ETP",
            "MobileGo",
            "Monaco",
            "MonaCoin",
            "Monero",
            "NAV Coin",
            "Neblio",
            "NEM",
            "NEO",
            "Nexus",
            "Nxt",
            "OmiseGO",
            "Open Trading ...",
            "Particl",
            "PIVX",
            "Populous",
            "Power Ledger",
            "Pura",
            "Qtum",
            "Raiden Networ...",
            "Ripio Credit ...",
            "Ripple",
            "SALT",
            "Siacoin",
            "SingularDTV",
            "Status",
            "Steem",
            "Stellar Lumens",
            "Storj",
            "Stratis",
            "Streamr DATAcoin",
            "Syscoin",
            "TenX",
            "Tether",
            "TRON",
            "Ubiq",
            "VeChain",
            "Verge",
            "Veritaseum",
            "Vertcoin",
            "Walton",
            "Waves",
            "Zcash",
            "ZCoin",
            "ZenCash",
            "Zeusshield"});
            this.cb_Crypto.Location = new System.Drawing.Point(28, 77);
            this.cb_Crypto.Name = "cb_Crypto";
            this.cb_Crypto.Size = new System.Drawing.Size(225, 28);
            this.cb_Crypto.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(282, 31);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(91, 40);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(282, 77);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(91, 40);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.Btn_del_Click);
            // 
            // btn_ins
            // 
            this.btn_ins.Location = new System.Drawing.Point(282, 123);
            this.btn_ins.Name = "btn_ins";
            this.btn_ins.Size = new System.Drawing.Size(91, 40);
            this.btn_ins.TabIndex = 3;
            this.btn_ins.Text = "Insert";
            this.btn_ins.UseVisualStyleBackColor = true;
            this.btn_ins.Click += new System.EventHandler(this.Btn_ins_Click);
            // 
            // tb_add
            // 
            this.tb_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_add.Location = new System.Drawing.Point(379, 37);
            this.tb_add.Name = "tb_add";
            this.tb_add.Size = new System.Drawing.Size(237, 27);
            this.tb_add.TabIndex = 4;
            // 
            // tb_del
            // 
            this.tb_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_del.Location = new System.Drawing.Point(379, 83);
            this.tb_del.Name = "tb_del";
            this.tb_del.Size = new System.Drawing.Size(237, 27);
            this.tb_del.TabIndex = 5;
            // 
            // tb_ins
            // 
            this.tb_ins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_ins.Location = new System.Drawing.Point(379, 129);
            this.tb_ins.Name = "tb_ins";
            this.tb_ins.Size = new System.Drawing.Size(237, 27);
            this.tb_ins.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cryptocurrency List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 247);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ins);
            this.Controls.Add(this.tb_del);
            this.Controls.Add(this.tb_add);
            this.Controls.Add(this.btn_ins);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_Crypto);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Crypto;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_ins;
        private System.Windows.Forms.TextBox tb_add;
        private System.Windows.Forms.TextBox tb_del;
        private System.Windows.Forms.TextBox tb_ins;
        private System.Windows.Forms.Label label1;
    }
}

