using System;

namespace Clase1{

    public class Estudiante : MiembroDeLaComunidad
    {
        public String MatriculaEstudiante { get; set; }
        public void Study(){
            base.GetMiembro();
        }
        public override void BeberAgua()
        {
            throw new NotImplementedException();
        }

        public override void Caminar()
        {
            throw new NotImplementedException();
        }

        public override void Quejarse()
        {
            throw new NotImplementedException();
        }
    }




}