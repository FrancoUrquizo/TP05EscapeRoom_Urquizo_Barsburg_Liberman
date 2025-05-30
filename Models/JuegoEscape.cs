using Newtonsoft.Json;    
public class JuegoEscape{

    [JsonProperty]
   private Dictionary<int, string> DicPistas ; 
     [JsonProperty]
   private Dictionary<int,string> DicRespuestasCorrectas;
   
    [JsonProperty] 
   public int Sala;

public JuegoEscape ()
{
DicPistas = new Dictionary<int, string>();
DicRespuestasCorrectas.Add(1, "2611");
DicRespuestasCorrectas.Add (2,"42");
DicRespuestasCorrectas.Add (3," HELP");
DicRespuestasCorrectas.Add (4, "True");

DicPistas = new Dictionary<int, string>();
DicPistas.Add(1, "¿Escuchás ese papel crujir? Tal vez deberías revisar bajo la cama o detrás de algún mueble.");  
DicPistas.Add(2, "¿Podés oír lo que se repite más de una vez? Los sonidos no son casuales.");  
DicPistas.Add(3, "¿Te acordás de los números de antes? No los sumes, pensá en otra forma de interpretarlos.");  
DicPistas.Add(4, "¿Notaste una parte de la pared más agrietada o descolorida? Algo está oculto detrás.");  

}

public bool compararRespuesta (string RespuestasUsuario)
{
bool SonIguales = false;

if (DicRespuestasCorrectas [Sala] == RespuestasUsuario)
{
Sala++;
SonIguales = true;

}
return SonIguales;
}

public string devolverPista ()
{
    return DicPistas[Sala];
} 


}