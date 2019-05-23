/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.br.control;

import com.br.model.*;
import javax.inject.Named;
import javax.enterprise.context.SessionScoped;
import java.io.Serializable;
import java.io.UnsupportedEncodingException;
import java.security.NoSuchAlgorithmException;
import java.util.List;
import javax.annotation.ManagedBean;
/**
 *
 * @author Hugo
 */
@ManagedBean
@Named(value = "clienteBean")
@SessionScoped
public class ClienteBean implements Serializable{
    private Cliente cliente = new Cliente();
    private ClienteDAO clienteDAO = new ClienteDAO();
    private List<Cliente> listaClientes;

    public Cliente getCliente() {
        return cliente;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    public ClienteDAO getClienteDAO() {
        return clienteDAO;
    }

    public void setClienteDAO(ClienteDAO clienteDAO) {
        this.clienteDAO = clienteDAO;
    }

    public List<Cliente> getListaClientes() {
        listaClientes = clienteDAO.listaTodosClientes();
        return listaClientes;
    }

    public void setListaClientes(List<Cliente> listaClientes) {
        this.listaClientes = listaClientes;
    }
    
    public String salvar() throws NoSuchAlgorithmException, UnsupportedEncodingException{
        if (clienteDAO.salvar(cliente))
            return "livros";
        else
            return "erro";
    }
    
    public String excluir(Cliente cliente){
        if(clienteDAO.excluir(cliente))
            return "livros";
        else
            return "erro";
    }
        
    public String atualizar(Cliente cliente)throws NoSuchAlgorithmException, UnsupportedEncodingException{
        if(clienteDAO.atualizar(cliente))
            return "livros";
        else
            return "erro";
    }
    
    
}
