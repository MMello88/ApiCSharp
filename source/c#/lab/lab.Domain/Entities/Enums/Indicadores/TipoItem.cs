using System;
using System.Collections.Generic;
using System.Text;

namespace lab.Domain.Entities.Enums.Indicadores
{
    public enum TipoItem
    {
        MercadoriaReenda = 00,
        MateriaPrima = 01,
        Embalagem = 02,
        ProdutoEmProcesso = 03,
        ProdutoAcabado = 04,
        SubProduto = 05,
        ProdutoIntermediario = 06,
        MaterialUsoConsumo = 07,
        AtivoImobilizado = 08,
        Servico = 09,
        OutrosInsumos = 10,
        Outras = 99
    }
}
