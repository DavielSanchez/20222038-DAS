using System;

namespace Clase1{

    public abstract class MiembroDeLaComunidad : MiembroDeLaComunidadd{
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual void Saludar(){
        }

        public abstract  void Quejarse();

        public abstract void Caminar();

        public abstract void BeberAgua();

        public MiembroDeLaComunidad GetMiembro()
        {
            throw new NotImplementedException();
        }
    }

}