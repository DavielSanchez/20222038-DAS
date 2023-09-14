using Clase1;

public interface MiembroDeLaComunidadd
{
    MiembroDeLaComunidad GetMiembro();
    public string Nombre { get; set; }
    void Saludar();
    void Quejarse();
    void Caminar();
    void BeberAgua();
}