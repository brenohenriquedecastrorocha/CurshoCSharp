﻿using System;
using System.Collections.Generic;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos",LendoDados.Executar },
                {"Formatando Numeros - Fundamentos",FormatandoNumeros.Executar },
                {"Operadores Aritmeticos - Fundamentos",OperadoresAritmeticos.Executar },
                {"Exercicios Operadores - Fundamentos",ExerciciosOperadores.Executar },
                {"Operadores Relacionais - Fundamentos",OperadoresRelacionais.Executar },
                {"Operadores Atribuição - Fundamentos",OperadoresAtribuicao.Executar},
                {"Estrutura WhileEFor",EstruturaWhileEFor.Executar},
                {"NumerosContados",NumerosContados.Executar },
                 
                // Estrutura de Controle
                {"EstuturaIf",EstruturaIf.Executar },
                {"Exerciciosif",Exerciciosif.Executar },

                //Classes e metodos 
                {"Membros",Membros.Executar },
                {"Carros",Carros.Executar },

            });

            central.SelecionarEExecutar();
        }
    }
}