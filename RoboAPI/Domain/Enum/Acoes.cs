﻿namespace RoboAPI.Domain
{
    public class Acoes
    {
        public enum Cotovelo
        {
            Repouso = 1,
            LevementeContraido = 2,
            Contraido = 3,
            FortementeContraido = 4
        }

        public enum Pulso
        {
            RotacaoMenos90 = 1,
            RotacaoMenos45 = 2,
            Repouso = 3,
            Rotacao45 = 4,
            Rotacao90 = 5,
            Rotacao135 = 6,
            Rotacao180 = 7
        }

        public enum Rotacao
        {
            RotacaoMenos90 = 1,
            RotacaoMenos45 = 2,
            Repouso = 3,
            Rotacao45 = 4,
            Rotacao90 = 5
        }

        public enum Inclinacao
        {
            ParaCima = 1,
            Repouso = 2,
            ParaBaixo = 3
        }

        public enum TipoAcao
        {
            Cotovelo = 1,
            Pulso = 2, 
            Rotacao = 3, 
            Inclinacao = 4
        }
    }
}
