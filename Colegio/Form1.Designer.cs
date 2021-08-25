
namespace Colegio
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
            this.tabProfesores = new System.Windows.Forms.TabControl();
            this.tabEstudiantes = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Buscar_Profesor = new System.Windows.Forms.Button();
            this.Borrar_Profesor = new System.Windows.Forms.Button();
            this.Modificar_Profesor = new System.Windows.Forms.Button();
            this.Guardar_Profesor = new System.Windows.Forms.Button();
            this.numerodocprofesor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tipodocprofesor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.apellidoprofesor = new System.Windows.Forms.TextBox();
            this.nombreprofesor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.idprofesor = new System.Windows.Forms.TextBox();
            this.nombrealumno = new System.Windows.Forms.TextBox();
            this.apellidoalumno = new System.Windows.Forms.TextBox();
            this.edad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tipodocalumno = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numerodocalumno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.Guardar_Alumno = new System.Windows.Forms.Button();
            this.Modificar_Alumno = new System.Windows.Forms.Button();
            this.Borrar_Alumno = new System.Windows.Forms.Button();
            this.Buscar_Alumno = new System.Windows.Forms.Button();
            this.idalumno = new System.Windows.Forms.TextBox();
            this.tabProfesores.SuspendLayout();
            this.tabEstudiantes.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabProfesores
            // 
            this.tabProfesores.AccessibleName = "";
            this.tabProfesores.Controls.Add(this.tabEstudiantes);
            this.tabProfesores.Controls.Add(this.tabPage2);
            this.tabProfesores.Controls.Add(this.tabPage4);
            this.tabProfesores.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProfesores.Location = new System.Drawing.Point(29, 23);
            this.tabProfesores.Name = "tabProfesores";
            this.tabProfesores.SelectedIndex = 0;
            this.tabProfesores.Size = new System.Drawing.Size(918, 485);
            this.tabProfesores.TabIndex = 0;
            // 
            // tabEstudiantes
            // 
            this.tabEstudiantes.BackColor = System.Drawing.Color.Gainsboro;
            this.tabEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabEstudiantes.Controls.Add(this.idalumno);
            this.tabEstudiantes.Controls.Add(this.Buscar_Alumno);
            this.tabEstudiantes.Controls.Add(this.Borrar_Alumno);
            this.tabEstudiantes.Controls.Add(this.Modificar_Alumno);
            this.tabEstudiantes.Controls.Add(this.Guardar_Alumno);
            this.tabEstudiantes.Controls.Add(this.direccion);
            this.tabEstudiantes.Controls.Add(this.label7);
            this.tabEstudiantes.Controls.Add(this.numerodocalumno);
            this.tabEstudiantes.Controls.Add(this.label6);
            this.tabEstudiantes.Controls.Add(this.tipodocalumno);
            this.tabEstudiantes.Controls.Add(this.label5);
            this.tabEstudiantes.Controls.Add(this.edad);
            this.tabEstudiantes.Controls.Add(this.apellidoalumno);
            this.tabEstudiantes.Controls.Add(this.nombrealumno);
            this.tabEstudiantes.Controls.Add(this.label4);
            this.tabEstudiantes.Controls.Add(this.label3);
            this.tabEstudiantes.Controls.Add(this.label2);
            this.tabEstudiantes.Controls.Add(this.label1);
            this.tabEstudiantes.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEstudiantes.Location = new System.Drawing.Point(4, 31);
            this.tabEstudiantes.Name = "tabEstudiantes";
            this.tabEstudiantes.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstudiantes.Size = new System.Drawing.Size(910, 450);
            this.tabEstudiantes.TabIndex = 0;
            this.tabEstudiantes.Text = "Estudiantes";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.idprofesor);
            this.tabPage2.Controls.Add(this.Buscar_Profesor);
            this.tabPage2.Controls.Add(this.Borrar_Profesor);
            this.tabPage2.Controls.Add(this.Modificar_Profesor);
            this.tabPage2.Controls.Add(this.Guardar_Profesor);
            this.tabPage2.Controls.Add(this.numerodocprofesor);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tipodocprofesor);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.apellidoprofesor);
            this.tabPage2.Controls.Add(this.nombreprofesor);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(910, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Profesores";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(910, 450);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Detalle de Cursos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Alumno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(14, 89);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellidos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(14, 122);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Edad";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Buscar_Profesor
            // 
            this.Buscar_Profesor.BackColor = System.Drawing.Color.DarkGray;
            this.Buscar_Profesor.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar_Profesor.Location = new System.Drawing.Point(357, 24);
            this.Buscar_Profesor.Name = "Buscar_Profesor";
            this.Buscar_Profesor.Size = new System.Drawing.Size(75, 39);
            this.Buscar_Profesor.TabIndex = 41;
            this.Buscar_Profesor.Text = "Buscar";
            this.Buscar_Profesor.UseVisualStyleBackColor = false;
            // 
            // Borrar_Profesor
            // 
            this.Borrar_Profesor.BackColor = System.Drawing.Color.LightCoral;
            this.Borrar_Profesor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar_Profesor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Borrar_Profesor.Location = new System.Drawing.Point(304, 212);
            this.Borrar_Profesor.Name = "Borrar_Profesor";
            this.Borrar_Profesor.Size = new System.Drawing.Size(116, 39);
            this.Borrar_Profesor.TabIndex = 40;
            this.Borrar_Profesor.Text = "Borrar";
            this.Borrar_Profesor.UseVisualStyleBackColor = false;
            // 
            // Modificar_Profesor
            // 
            this.Modificar_Profesor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Modificar_Profesor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar_Profesor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Modificar_Profesor.Location = new System.Drawing.Point(170, 212);
            this.Modificar_Profesor.Name = "Modificar_Profesor";
            this.Modificar_Profesor.Size = new System.Drawing.Size(116, 39);
            this.Modificar_Profesor.TabIndex = 39;
            this.Modificar_Profesor.Text = "Modificar";
            this.Modificar_Profesor.UseVisualStyleBackColor = false;
            // 
            // Guardar_Profesor
            // 
            this.Guardar_Profesor.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Guardar_Profesor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_Profesor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Guardar_Profesor.Location = new System.Drawing.Point(36, 212);
            this.Guardar_Profesor.Name = "Guardar_Profesor";
            this.Guardar_Profesor.Size = new System.Drawing.Size(116, 39);
            this.Guardar_Profesor.TabIndex = 38;
            this.Guardar_Profesor.Text = "Guardar";
            this.Guardar_Profesor.UseVisualStyleBackColor = false;
            // 
            // numerodocprofesor
            // 
            this.numerodocprofesor.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerodocprofesor.Location = new System.Drawing.Point(213, 166);
            this.numerodocprofesor.Name = "numerodocprofesor";
            this.numerodocprofesor.Size = new System.Drawing.Size(207, 25);
            this.numerodocprofesor.TabIndex = 35;
            this.numerodocprofesor.Text = "1143364059";
            // 
            // label10
            // 
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(32, 167);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(169, 25);
            this.label10.TabIndex = 34;
            this.label10.Text = "Número de Documento";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tipodocprofesor
            // 
            this.tipodocprofesor.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipodocprofesor.FormattingEnabled = true;
            this.tipodocprofesor.Location = new System.Drawing.Point(213, 132);
            this.tipodocprofesor.Name = "tipodocprofesor";
            this.tipodocprofesor.Size = new System.Drawing.Size(121, 27);
            this.tipodocprofesor.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(32, 133);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(169, 25);
            this.label11.TabIndex = 32;
            this.label11.Text = "Tipo de Documento";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // apellidoprofesor
            // 
            this.apellidoprofesor.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoprofesor.Location = new System.Drawing.Point(213, 100);
            this.apellidoprofesor.Name = "apellidoprofesor";
            this.apellidoprofesor.Size = new System.Drawing.Size(207, 25);
            this.apellidoprofesor.TabIndex = 30;
            this.apellidoprofesor.Text = "SERRANO TAPIA";
            // 
            // nombreprofesor
            // 
            this.nombreprofesor.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreprofesor.Location = new System.Drawing.Point(213, 68);
            this.nombreprofesor.Name = "nombreprofesor";
            this.nombreprofesor.Size = new System.Drawing.Size(207, 25);
            this.nombreprofesor.TabIndex = 29;
            this.nombreprofesor.Text = "ALFONSO";
            // 
            // label13
            // 
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(32, 99);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(169, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "Apellidos";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Location = new System.Drawing.Point(32, 65);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(169, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "Nombre";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.Location = new System.Drawing.Point(32, 31);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(169, 25);
            this.label16.TabIndex = 24;
            this.label16.Text = "Id Profesor";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idprofesor
            // 
            this.idprofesor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idprofesor.Location = new System.Drawing.Point(213, 29);
            this.idprofesor.Multiline = true;
            this.idprofesor.Name = "idprofesor";
            this.idprofesor.Size = new System.Drawing.Size(138, 31);
            this.idprofesor.TabIndex = 42;
            this.idprofesor.Text = "0000001";
            this.idprofesor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nombrealumno
            // 
            this.nombrealumno.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrealumno.Location = new System.Drawing.Point(136, 60);
            this.nombrealumno.Name = "nombrealumno";
            this.nombrealumno.Size = new System.Drawing.Size(207, 25);
            this.nombrealumno.TabIndex = 11;
            this.nombrealumno.Text = "ALFONSO";
            // 
            // apellidoalumno
            // 
            this.apellidoalumno.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoalumno.Location = new System.Drawing.Point(136, 91);
            this.apellidoalumno.Name = "apellidoalumno";
            this.apellidoalumno.Size = new System.Drawing.Size(207, 25);
            this.apellidoalumno.TabIndex = 12;
            this.apellidoalumno.Text = "SERRANO TAPIA";
            // 
            // edad
            // 
            this.edad.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad.Location = new System.Drawing.Point(136, 122);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(39, 25);
            this.edad.TabIndex = 13;
            this.edad.Text = "28";
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(371, 23);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(209, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tipo de Documento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tipodocalumno
            // 
            this.tipodocalumno.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipodocalumno.FormattingEnabled = true;
            this.tipodocalumno.Location = new System.Drawing.Point(586, 20);
            this.tipodocalumno.Name = "tipodocalumno";
            this.tipodocalumno.Size = new System.Drawing.Size(233, 27);
            this.tipodocalumno.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(371, 58);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(209, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Número de Documento";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numerodocalumno
            // 
            this.numerodocalumno.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerodocalumno.Location = new System.Drawing.Point(586, 56);
            this.numerodocalumno.Name = "numerodocalumno";
            this.numerodocalumno.Size = new System.Drawing.Size(102, 25);
            this.numerodocalumno.TabIndex = 17;
            this.numerodocalumno.Text = "1143364059";
            this.numerodocalumno.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(371, 93);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(209, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Dirección";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // direccion
            // 
            this.direccion.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion.Location = new System.Drawing.Point(586, 91);
            this.direccion.Multiline = true;
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(295, 75);
            this.direccion.TabIndex = 19;
            this.direccion.Text = "Cra 87 #22 - 37 - Cartagena Colombia";
            // 
            // Guardar_Alumno
            // 
            this.Guardar_Alumno.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Guardar_Alumno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_Alumno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Guardar_Alumno.Location = new System.Drawing.Point(487, 184);
            this.Guardar_Alumno.Name = "Guardar_Alumno";
            this.Guardar_Alumno.Size = new System.Drawing.Size(116, 39);
            this.Guardar_Alumno.TabIndex = 20;
            this.Guardar_Alumno.Text = "Guardar";
            this.Guardar_Alumno.UseVisualStyleBackColor = false;
            // 
            // Modificar_Alumno
            // 
            this.Modificar_Alumno.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Modificar_Alumno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar_Alumno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Modificar_Alumno.Location = new System.Drawing.Point(626, 184);
            this.Modificar_Alumno.Name = "Modificar_Alumno";
            this.Modificar_Alumno.Size = new System.Drawing.Size(116, 39);
            this.Modificar_Alumno.TabIndex = 21;
            this.Modificar_Alumno.Text = "Modificar";
            this.Modificar_Alumno.UseVisualStyleBackColor = false;
            // 
            // Borrar_Alumno
            // 
            this.Borrar_Alumno.BackColor = System.Drawing.Color.LightCoral;
            this.Borrar_Alumno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar_Alumno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Borrar_Alumno.Location = new System.Drawing.Point(765, 184);
            this.Borrar_Alumno.Name = "Borrar_Alumno";
            this.Borrar_Alumno.Size = new System.Drawing.Size(116, 39);
            this.Borrar_Alumno.TabIndex = 22;
            this.Borrar_Alumno.Text = "Borrar";
            this.Borrar_Alumno.UseVisualStyleBackColor = false;
            // 
            // Buscar_Alumno
            // 
            this.Buscar_Alumno.BackColor = System.Drawing.Color.DarkGray;
            this.Buscar_Alumno.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar_Alumno.Location = new System.Drawing.Point(280, 23);
            this.Buscar_Alumno.Name = "Buscar_Alumno";
            this.Buscar_Alumno.Size = new System.Drawing.Size(75, 32);
            this.Buscar_Alumno.TabIndex = 23;
            this.Buscar_Alumno.Text = "Buscar";
            this.Buscar_Alumno.UseVisualStyleBackColor = false;
            // 
            // idalumno
            // 
            this.idalumno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idalumno.Location = new System.Drawing.Point(136, 23);
            this.idalumno.Multiline = true;
            this.idalumno.Name = "idalumno";
            this.idalumno.Size = new System.Drawing.Size(138, 31);
            this.idalumno.TabIndex = 24;
            this.idalumno.Text = "0000001";
            this.idalumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 520);
            this.Controls.Add(this.tabProfesores);
            this.Name = "Form1";
            this.Text = "Colegio Softtek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabProfesores.ResumeLayout(false);
            this.tabEstudiantes.ResumeLayout(false);
            this.tabEstudiantes.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProfesores;
        private System.Windows.Forms.TabPage tabEstudiantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Buscar_Profesor;
        private System.Windows.Forms.Button Borrar_Profesor;
        private System.Windows.Forms.Button Modificar_Profesor;
        private System.Windows.Forms.Button Guardar_Profesor;
        private System.Windows.Forms.TextBox numerodocprofesor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox tipodocprofesor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox apellidoprofesor;
        private System.Windows.Forms.TextBox nombreprofesor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox idprofesor;
        private System.Windows.Forms.TextBox idalumno;
        private System.Windows.Forms.Button Buscar_Alumno;
        private System.Windows.Forms.Button Borrar_Alumno;
        private System.Windows.Forms.Button Modificar_Alumno;
        private System.Windows.Forms.Button Guardar_Alumno;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numerodocalumno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tipodocalumno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.TextBox apellidoalumno;
        private System.Windows.Forms.TextBox nombrealumno;
    }
}

