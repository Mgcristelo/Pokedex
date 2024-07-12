using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Habilidade do pokemon", menuName = "Pokemon/Habilidade")]
public class HabilidadePokemon : ScriptableObject
{
    public string nome;
    public TipoPokemon tipoHabilidade;
    public string descricao;
    public int ppMax;

}
