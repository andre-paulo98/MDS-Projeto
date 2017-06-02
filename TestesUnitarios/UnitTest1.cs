using System;
using ProjetoMDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesUnitarios {
    [TestClass]
    
    public class UnitTest1 {
        MedicosRepository medicoRepo = new MedicosRepository();
        private string medicoUsername = "MedicoTesteUnitario";
        private string medicoPassword = Tools.HashPassword("MedicoTesteUnitario");

        [TestMethod]
        public void TestMethod1() {
            Medico medico = new Medico();
            Medico medicoBaseDados = new Medico();

            medico.username = medicoUsername;
            medico.password = medicoPassword;
            medico.permissao = 0;
            medico.especialidade = "Pediatria";
            medico.entrada = new DateTime(2017, 06, 02, 01, 00, 00);
            medico.saida = new DateTime(2017, 06, 02, 02, 00, 00);
            medico.nSegSocial = 987654321;
            medicoRepo.Add(medico);

            medicoBaseDados = medicoRepo.getMedicoList(medicoUsername);
            if(!medicoRepo.checkTwoMedics(medico, medicoBaseDados)) {
                Console.WriteLine(medico.username == medicoBaseDados.username);
                Console.WriteLine(medico.password == medicoBaseDados.password);
                Console.WriteLine(medico.permissao == medicoBaseDados.permissao);
                Console.WriteLine(medico.especialidade == medicoBaseDados.especialidade);
                Console.WriteLine(medico.entrada == medicoBaseDados.entrada);
                Console.WriteLine(medico.saida == medicoBaseDados.saida);
                Console.WriteLine(medico.nSegSocial == medicoBaseDados.nSegSocial);
                Console.WriteLine(medico.cargo == medicoBaseDados.cargo);
                Console.WriteLine(medico.id == medicoBaseDados.id);
                throw new Exception("Medicos são diferentes");
            }
            
        }

        /*[TestMethod]
        public void TestMethod2() {

        }*/
    }
}
