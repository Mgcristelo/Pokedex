using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEditor.Progress;

public class Pokedex : MonoBehaviour
{
    [Header("Lista de Pokemons")]
    public Pokemon[] listaPokemons;

    [Header("Objetos da cena Pokedex")]
    public Image imagemPokemon;
    public TMP_Text nomePokemon;
    public TMP_Text descricaoPokemon;
    public TMP_Text tipoPokemon;

    [Header("Objetos da cena Habilidades")]
    public TMP_Text textoHabilidades;

    [Header("Objetos da cena Evolução")]
    public TMP_Text textoEvolucoes;

    [Header("Variaveis para Pokedex")]
    public int pokemonAtual;

    private void Start()
    {
        MudarPokemon(0);
    }

    public void MudarPokemon(int proximo)
    {
        if (proximo == 0)
        {
            imagemPokemon.sprite = listaPokemons[pokemonAtual].imagemPokemon;
            nomePokemon.text = listaPokemons[pokemonAtual].nome;
            descricaoPokemon.text = listaPokemons[pokemonAtual].descricao;

            tipoPokemon.text = "";
            textoHabilidades.text = "";
            textoEvolucoes.text = "";

            for (int i = 0; i < listaPokemons[pokemonAtual].tipo.Length; i++)
            {
                tipoPokemon.text += listaPokemons[pokemonAtual].tipo[i].name + " - ";
            }

            for (int i = 0; i < listaPokemons[pokemonAtual].habilidades.Length; i++)
            {
                textoHabilidades.text += listaPokemons[pokemonAtual].habilidades[i].nome + "\n";
            }

            if (listaPokemons[pokemonAtual].preEvolucao != null)
            {
                textoEvolucoes.text = "pre: " + listaPokemons[pokemonAtual].preEvolucao.nome;
            }
            else
            {
                textoEvolucoes.text = "pre: não possui";
            }

            if (listaPokemons[pokemonAtual].evolucao != null)
            {
                textoEvolucoes.text += "\n Pós: " + listaPokemons[pokemonAtual].evolucao.nome;
            }

            else
            {
                textoEvolucoes.text += "\n Pós: Não possui";
            }
        }
        else
        {
            pokemonAtual += proximo;

            if (pokemonAtual < 0)
            {
                pokemonAtual = listaPokemons.Length - 1;
            }
            if (pokemonAtual > listaPokemons.Length)
            {
                pokemonAtual = 0;
            }

            imagemPokemon.sprite = listaPokemons[pokemonAtual].imagemPokemon;
            nomePokemon.text = listaPokemons[pokemonAtual].nome;
            descricaoPokemon.text = listaPokemons[pokemonAtual].descricao;

            tipoPokemon.text = "";
            textoHabilidades.text = "";
            textoEvolucoes.text = "";

            for (int i = 0; i < listaPokemons[pokemonAtual].tipo.Length; i++)
            {
                tipoPokemon.text += listaPokemons[pokemonAtual].tipo[i].name + " - ";
            }
            for (int i = 0; i < listaPokemons[pokemonAtual].habilidades.Length; i++)
            {
                textoHabilidades.text += listaPokemons[pokemonAtual].habilidades[i].nome + "\n";
            }
            if (listaPokemons[pokemonAtual].preEvolucao != null)
            {
                textoEvolucoes.text = "pre: " + listaPokemons[pokemonAtual].preEvolucao.nome;
            }
            else
            {
                textoEvolucoes.text = "pre: não possui";
            }
            if (listaPokemons[pokemonAtual].evolucao != null)
            {
                textoEvolucoes.text += "\n Pós: " + listaPokemons[pokemonAtual].evolucao.nome;
            }
            else
            {
                textoEvolucoes.text += "\n Pós: Não possui";
            }

        }
    }

}
