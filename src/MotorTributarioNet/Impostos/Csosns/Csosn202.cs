﻿using MotorTributarioNet.Flags;

namespace MotorTributarioNet.Impostos.Csosns
{
    public class Csosn202 : Csosn102
    {
        public Csosn202(OrigemMercadoria origemMercadoria) : base(origemMercadoria)
        {
            Csosn = Csosn.Csosn202;
        }

        public ModalidadeDeterminacaoBcIcmsSt ModalidadeDeterminacaoBcIcmsSt { get; set; }
        public decimal ValorBcIcmsSt { get; set; }
        public decimal PercentualIcmsSt { get; set; }
        public decimal ValorIcmsSt { get; set; }
    }
}