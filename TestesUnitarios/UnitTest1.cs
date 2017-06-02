using System;
using ProjetoMDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesUnitarios {
    [TestClass]
    
    public class UnitTest1 {
        MedicosRepository medicoRepo = new MedicosRepository();
        UserRepository userRepo = new UserRepository();
        private string medicoUsername = "MedicoTesteUnitario";
        private string medicoPassword = Tools.HashPassword("MedicoTesteUnitario");

        [TestMethod]
        public void TesteAdicionaMedico() {
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
                medicoRepo.eliminaMedico(medicoUsername);
                throw new Exception("Medicos são diferentes");
            }
            medicoRepo.eliminaMedico(medicoUsername);

        }

        [TestMethod]
        public void TesteLoginMedico() {
            Medico medico = new Medico();

            medico.username = medicoUsername;
            medico.password = medicoPassword;
            medico.permissao = 0;
            medico.especialidade = "Pediatria";
            medico.entrada = new DateTime(2017, 06, 02, 01, 00, 00);
            medico.saida = new DateTime(2017, 06, 02, 02, 00, 00);
            medico.nSegSocial = 987654321;
            medicoRepo.Add(medico);

            if(!userRepo.Login(medicoUsername, medicoPassword)) {
                medicoRepo.eliminaMedico(medicoUsername);
                throw new Exception("Login incorreto");
            }
            medicoRepo.eliminaMedico(medicoUsername);

        }
    }
}
