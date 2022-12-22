namespace TransaccionNotificationService
{
    partial class Service1
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NotificationT = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationT)).BeginInit();
            // 
            // NotificationT
            // 
            this.NotificationT.Enabled = true;
            this.NotificationT.Interval = 10000D;
            this.NotificationT.Elapsed += new System.Timers.ElapsedEventHandler(this.NotificationT_Elapsed);
            // 
            // Service1
            // 
            this.ServiceName = "Service1";
            ((System.ComponentModel.ISupportInitialize)(this.NotificationT)).EndInit();

        }

        #endregion

        private System.Timers.Timer NotificationT;
    }
}
