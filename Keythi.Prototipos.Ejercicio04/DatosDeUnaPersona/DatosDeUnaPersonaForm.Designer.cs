namespace Keythi.Prototipos.Ejercicio04.DatosDeUnaPersona
{
    partial class DatosDeUnaPersonaForm
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
            botonNuevoIngreso = new Button();
            botonModificarPersona = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtDocumento = new TextBox();
            TxtNombre = new TextBox();
            TxtApellido = new TextBox();
            TxtCodPais = new TextBox();
            ComboBoxTiposTel = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtCodArea = new TextBox();
            TxtNumTel = new TextBox();
            listViewPersona = new ListView();
            dniColumn = new ColumnHeader();
            nombreColumn = new ColumnHeader();
            apellidoColumn = new ColumnHeader();
            tipoColumn = new ColumnHeader();
            codigoPaisColumn = new ColumnHeader();
            codigoAreaColumn = new ColumnHeader();
            numeroTelColumn = new ColumnHeader();
            botonEliminarPersona = new Button();
            grupoColumnasPersonas = new GroupBox();
            botonAceptar = new Button();
            botonFinalizar = new Button();
            grupoAñadirElemento = new GroupBox();
            grupoColumnasPersonas.SuspendLayout();
            grupoAñadirElemento.SuspendLayout();
            SuspendLayout();
            // 
            // botonNuevoIngreso
            // 
            botonNuevoIngreso.Location = new Point(277, 205);
            botonNuevoIngreso.Name = "botonNuevoIngreso";
            botonNuevoIngreso.Size = new Size(125, 29);
            botonNuevoIngreso.TabIndex = 0;
            botonNuevoIngreso.Text = "Nuevo ingreso";
            botonNuevoIngreso.UseVisualStyleBackColor = true;
            botonNuevoIngreso.Click += button1_Click;
            // 
            // botonModificarPersona
            // 
            botonModificarPersona.Location = new Point(437, 205);
            botonModificarPersona.Name = "botonModificarPersona";
            botonModificarPersona.Size = new Size(151, 29);
            botonModificarPersona.TabIndex = 1;
            botonModificarPersona.Text = "Modificar elemento";
            botonModificarPersona.UseVisualStyleBackColor = true;
            botonModificarPersona.Click += botonModificarPersona_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 2;
            label1.Text = "Documento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 16);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 16);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 99);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 5;
            label4.Text = "Tipo de telefono";
            // 
            // TxtDocumento
            // 
            TxtDocumento.Location = new Point(12, 40);
            TxtDocumento.Name = "TxtDocumento";
            TxtDocumento.Size = new Size(125, 27);
            TxtDocumento.TabIndex = 6;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(163, 39);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(125, 27);
            TxtNombre.TabIndex = 7;
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(320, 39);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(125, 27);
            TxtApellido.TabIndex = 8;
            // 
            // TxtCodPais
            // 
            TxtCodPais.Location = new Point(184, 123);
            TxtCodPais.Name = "TxtCodPais";
            TxtCodPais.Size = new Size(125, 27);
            TxtCodPais.TabIndex = 9;
            // 
            // ComboBoxTiposTel
            // 
            ComboBoxTiposTel.FormattingEnabled = true;
            ComboBoxTiposTel.Items.AddRange(new object[] { "CASA", "TRABAJO", "OTRO" });
            ComboBoxTiposTel.Location = new Point(12, 122);
            ComboBoxTiposTel.Name = "ComboBoxTiposTel";
            ComboBoxTiposTel.Size = new Size(151, 28);
            ComboBoxTiposTel.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(184, 99);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 11;
            label5.Text = "Codigo de pais";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(331, 100);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 12;
            label6.Text = "Codigo de Area";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(477, 100);
            label7.Name = "label7";
            label7.Size = new Size(144, 20);
            label7.TabIndex = 13;
            label7.Text = "Numero de telefono";
            // 
            // TxtCodArea
            // 
            TxtCodArea.Location = new Point(330, 123);
            TxtCodArea.Name = "TxtCodArea";
            TxtCodArea.Size = new Size(125, 27);
            TxtCodArea.TabIndex = 14;
            // 
            // TxtNumTel
            // 
            TxtNumTel.Location = new Point(477, 123);
            TxtNumTel.Name = "TxtNumTel";
            TxtNumTel.Size = new Size(144, 27);
            TxtNumTel.TabIndex = 15;
            // 
            // listViewPersona
            // 
            listViewPersona.Columns.AddRange(new ColumnHeader[] { dniColumn, nombreColumn, apellidoColumn, tipoColumn, codigoPaisColumn, codigoAreaColumn, numeroTelColumn });
            listViewPersona.Location = new Point(12, 12);
            listViewPersona.Name = "listViewPersona";
            listViewPersona.Size = new Size(749, 187);
            listViewPersona.TabIndex = 16;
            listViewPersona.UseCompatibleStateImageBehavior = false;
            listViewPersona.View = View.Details;
            listViewPersona.SelectedIndexChanged += listViewPersona_SelectedIndexChanged;
            // 
            // dniColumn
            // 
            dniColumn.Text = "DNI";
            dniColumn.Width = 80;
            // 
            // nombreColumn
            // 
            nombreColumn.Text = "Nombre";
            nombreColumn.Width = 80;
            // 
            // apellidoColumn
            // 
            apellidoColumn.Text = "Apellido";
            apellidoColumn.Width = 80;
            // 
            // tipoColumn
            // 
            tipoColumn.Text = "Tipo de telefono";
            tipoColumn.Width = 125;
            // 
            // codigoPaisColumn
            // 
            codigoPaisColumn.Text = "Codigo de pais";
            codigoPaisColumn.Width = 115;
            // 
            // codigoAreaColumn
            // 
            codigoAreaColumn.Text = "Codigo de area";
            codigoAreaColumn.Width = 115;
            // 
            // numeroTelColumn
            // 
            numeroTelColumn.Text = "Numero de telefono";
            numeroTelColumn.Width = 150;
            // 
            // botonEliminarPersona
            // 
            botonEliminarPersona.Location = new Point(620, 205);
            botonEliminarPersona.Name = "botonEliminarPersona";
            botonEliminarPersona.Size = new Size(141, 29);
            botonEliminarPersona.TabIndex = 17;
            botonEliminarPersona.Text = "Eliminar elemento";
            botonEliminarPersona.UseVisualStyleBackColor = true;
            botonEliminarPersona.Click += botonEliminarPersona_Click;
            // 
            // grupoColumnasPersonas
            // 
            grupoColumnasPersonas.Controls.Add(botonEliminarPersona);
            grupoColumnasPersonas.Controls.Add(listViewPersona);
            grupoColumnasPersonas.Controls.Add(botonModificarPersona);
            grupoColumnasPersonas.Controls.Add(botonNuevoIngreso);
            grupoColumnasPersonas.Location = new Point(0, 0);
            grupoColumnasPersonas.Name = "grupoColumnasPersonas";
            grupoColumnasPersonas.Size = new Size(839, 246);
            grupoColumnasPersonas.TabIndex = 18;
            grupoColumnasPersonas.TabStop = false;
            // 
            // botonAceptar
            // 
            botonAceptar.Location = new Point(550, 165);
            botonAceptar.Name = "botonAceptar";
            botonAceptar.Size = new Size(94, 29);
            botonAceptar.TabIndex = 19;
            botonAceptar.Text = "Aceptar";
            botonAceptar.UseVisualStyleBackColor = true;
            botonAceptar.Click += botonAceptar_Click;
            // 
            // botonFinalizar
            // 
            botonFinalizar.Location = new Point(667, 165);
            botonFinalizar.Name = "botonFinalizar";
            botonFinalizar.Size = new Size(94, 29);
            botonFinalizar.TabIndex = 20;
            botonFinalizar.Text = "Finalizar";
            botonFinalizar.UseVisualStyleBackColor = true;
            botonFinalizar.Click += botonFinalizar_Click;
            // 
            // grupoAñadirElemento
            // 
            grupoAñadirElemento.Controls.Add(botonFinalizar);
            grupoAñadirElemento.Controls.Add(botonAceptar);
            grupoAñadirElemento.Controls.Add(TxtNumTel);
            grupoAñadirElemento.Controls.Add(TxtCodArea);
            grupoAñadirElemento.Controls.Add(label7);
            grupoAñadirElemento.Controls.Add(label6);
            grupoAñadirElemento.Controls.Add(label5);
            grupoAñadirElemento.Controls.Add(ComboBoxTiposTel);
            grupoAñadirElemento.Controls.Add(TxtCodPais);
            grupoAñadirElemento.Controls.Add(TxtApellido);
            grupoAñadirElemento.Controls.Add(TxtNombre);
            grupoAñadirElemento.Controls.Add(TxtDocumento);
            grupoAñadirElemento.Controls.Add(label4);
            grupoAñadirElemento.Controls.Add(label3);
            grupoAñadirElemento.Controls.Add(label2);
            grupoAñadirElemento.Controls.Add(label1);
            grupoAñadirElemento.Location = new Point(0, 252);
            grupoAñadirElemento.Name = "grupoAñadirElemento";
            grupoAñadirElemento.Size = new Size(847, 220);
            grupoAñadirElemento.TabIndex = 21;
            grupoAñadirElemento.TabStop = false;
            // 
            // DatosDeUnaPersonaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 470);
            Controls.Add(grupoAñadirElemento);
            Controls.Add(grupoColumnasPersonas);
            Name = "DatosDeUnaPersonaForm";
            Text = "DatosDeUnaPersonaForm";
            Load += DatosDeUnaPersonaForm_Load;
            grupoColumnasPersonas.ResumeLayout(false);
            grupoAñadirElemento.ResumeLayout(false);
            grupoAñadirElemento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button botonNuevoIngreso;
        private Button botonModificarPersona;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtDocumento;
        private TextBox TxtNombre;
        private TextBox TxtApellido;
        private TextBox TxtCodPais;
        private ComboBox ComboBoxTiposTel;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtCodArea;
        private TextBox TxtNumTel;
        private ListView listViewPersona;
        private ColumnHeader dniColumn;
        private ColumnHeader nombreColumn;
        private ColumnHeader apellidoColumn;
        private ColumnHeader tipoColumn;
        private ColumnHeader codigoPaisColumn;
        private ColumnHeader codigoAreaColumn;
        private ColumnHeader numeroTelColumn;
        private Button botonEliminarPersona;
        private GroupBox grupoColumnasPersonas;
        private Button botonAceptar;
        private Button botonFinalizar;
        private GroupBox grupoAñadirElemento;
    }
}