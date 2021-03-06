﻿using System;
using System.Collections.Generic;
using System.Linq;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDEnderecosClientes;
using SalaoDoPantcho.SGBD.Repository.RepositoryBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.SGBD.Repository.RepositoryEntity.RepositoryEnderecosClientes
{
    public class RepositoryEnderecosCliente : RepositoryBase<EnderecosCliente, Int32>, IContractsSGBDEnderecosCliente
    {
        #region Implementação Métodos Persistentes

        public EnderecosCliente PesquisarEnderecoPorTipoEnderecoPersistence(TipoEnderecos tipoEndereco)
        {
            if (tipoEndereco != 0)
            {
                try
                {
                    EnderecosCliente enderecoClientePorTipoEnderecos = dataContext.EnderecosCliente.AsParallel()
                                                                .Where(endereco => endereco.TipoEndereco == tipoEndereco)
                                                                .FirstOrDefault();
                    if (enderecoClientePorTipoEnderecos != null)
                    {
                        dataContext.Dispose();
                        return enderecoClientePorTipoEnderecos;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return null;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                return null;
            }
        }

        public EnderecosCliente PesquisarEnderecoPorBairroPersistence(string bairro)
        {
            if (!string.IsNullOrEmpty(bairro))
            {
                try
                {
                    EnderecosCliente enderecoClientePorBairro = dataContext.EnderecosCliente.AsParallel()
                                                                .Where(endereco => endereco.Bairro == bairro)
                                                                .FirstOrDefault();
                    if (enderecoClientePorBairro != null)
                    {
                        dataContext.Dispose();
                        return enderecoClientePorBairro;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return null;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                return null;
            }
        }

        public EnderecosCliente PesquisarEnderecoPorCepPersistence(string cep)
        {
            if (!string.IsNullOrEmpty(cep))
            {
                try
                {
                    EnderecosCliente enderecoClientePorCep = dataContext.EnderecosCliente.AsParallel()
                                                             .Where(endereco => endereco.CEP == cep)
                                                             .FirstOrDefault();
                    if (enderecoClientePorCep != null)
                    {
                        dataContext.Dispose();
                        return enderecoClientePorCep;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return null;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                return null;
            }
        }

        //_________________

        public ICollection<EnderecosCliente> PesquisarEnderecosPorBairroPersistence(string bairro)
        {
            if (!string.IsNullOrEmpty(bairro))
            {
                try
                {
                    List<EnderecosCliente> enderecoClientePorBairro = dataContext.EnderecosCliente.AsParallel().
                                                                      Where(endereco => endereco.Bairro == bairro)
                                                                      .ToList();
                    if (enderecoClientePorBairro != null)
                    {
                        dataContext.Dispose();
                        return enderecoClientePorBairro;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return null;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                return null;
            }
        }

        public ICollection<EnderecosCliente> PesquisarEnderecosPorCepPersistence(string cep)
        {
            if (!string.IsNullOrEmpty(cep))
            {
                try
                {
                    List<EnderecosCliente> enderecoClientePorCep = dataContext.EnderecosCliente.AsParallel().
                                                                   Where(endereco => endereco.CEP == cep)
                                                                   .ToList();
                    if (enderecoClientePorCep != null)
                    {
                        dataContext.Dispose();
                        return enderecoClientePorCep;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return null;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                return null;
            }
        }

        public ICollection<EnderecosCliente> PesquisarEnderecosPorTipoEnderecosPersistence(TipoEnderecos tipoEndereco)
        {
            if (tipoEndereco != 0)
            {
                try
                {
                    List<EnderecosCliente> enderecoClientePorTipoEnderecos = dataContext.EnderecosCliente.AsParallel().
                                                                             Where(endereco => endereco.TipoEndereco == tipoEndereco)
                                                                             .ToList();
                    if (enderecoClientePorTipoEnderecos != null)
                    {
                        dataContext.Dispose();
                        return enderecoClientePorTipoEnderecos;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return null;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                return null;
            }
        }

        #endregion
    }
}