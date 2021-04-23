﻿using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notacao ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numero - Fundamentos", FormatandoNumero.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuicao - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar},
                
                // Estruturas de controle
                {"Estrutura If - Estruturas de controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de controle", UsandoContinue.Executar},
            
                // Classes e Metodos
                {"Membros - Classes e metodos", Membros.Executar},
                {"Construtores - Classes e metodos", Construtores.Executar},
                {"Metodos com retorno - Classes e metodos", MetodosComRetorno.Executar},
                {"Metodos Estaticos - Classes e metodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e metodos", AtributosEstaticos.Executar},
                {"Desafio Atributos - Classes e metodos", DesafioAtributos.Executar},
                {"Params - Classes e metodos", Params.Executar},
                {"Parametros nomeados - Classes e metodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e metodos", GetSet.Executar},
                {"Props - Classes e metodos", Props.Executar},
                {"Readonly - Classes e metodos", Readonly.Executar},
                {"Enum - Classes e metodos", ExemploEnum.Executar},
                {"Struct - Classes e metodos", Struct.Executar},
                {"Struct VS Classe - Classes e metodos", StructVsClasse.Executar},
                {"Valor VS Referencia - Classes e metodos", ValorVsReferencia.Executar},
                {"Parametros por referencia - Classes e metodos", ParametrosPorReferencia.Executar},
                {"Parametro com valor padrao - Classes e metodos", ParametroPadrao.Executar},
             
                // Colecoes
                {"Array - Colecoes", Colecoes.Array.Executar},
                {"List - Colecoes", ColecoesList.Executar},
                {"ArrayList - Colecoes", ColecoesArrayList.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}