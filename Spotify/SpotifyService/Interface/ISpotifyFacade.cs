using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Spotify.Interface
{
    /// <summary>
    /// Implementação do Design Pattern Façade
    /// Classe responsável por realizar a inicialização do banco de dados 
    /// com base na API do Sporfy
    /// </summary>
    public interface ISpotifyFacade
    {
        /// <summary>
        /// Realiza chamada dos serviços do Spotify para buscar álbuns na API e alimentar Banco de Dados
        /// </summary>
        void PrepareEnvironment();
    }
}
