using System;
using ProjetoMDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestesUnitarios {
    [TestClass]
    
    public class UnitTest1 {
        MedioRepository medicoRepo = new MedioRepository();
        
        [TestMethod]
        public void TestMethod1() {
            Medico medico = new Medico();

            medico.username = "MedicoTeste";
            medico.password = Tools.HashPassword("teste");
            medico.permissao = 0;
            medico.especialidade = "Pediatria";
            medico.entrada = new DateTime(2017, 06, 02, 01, 00, 00);
            medico.saida = new DateTime(2017, 06, 02, 02, 00, 00);
            medico.nSegSocial = 987654321;
            medicoRepo.Add(medico);

            
        }
    }
}
