/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.br.model;

import com.br.util.HibernateUtil;
import java.util.List;
import org.hibernate.HibernateException;
import org.hibernate.SQLQuery;
import org.hibernate.Session;
import org.hibernate.Transaction;

/**
 *
 * @author Hugo
 */
public class ClienteDAO {
    private Session sessao;
    private Transaction transacao;
    private List<Cliente> listaClientes;

    public List<Cliente> getListaClientes() {
        return listaClientes;
    }

    public void setListaClientes(List<Cliente> listaClientes) {
        this.listaClientes = listaClientes;
    }
    
    public List<Cliente> listaTodosClientes(){
        sessao = HibernateUtil.getSessionFactory().openSession();
        transacao = sessao.beginTransaction();
        String sql = "SELECT * FROM cliente";
        SQLQuery consulta = sessao.createSQLQuery(sql);
        consulta.addEntity(Cliente.class);
        listaClientes = consulta.list();
        transacao.commit();
        return listaClientes;
    }
    
    
    public boolean salvar(Cliente cliente){
        try{
            sessao = HibernateUtil.getSessionFactory().openSession();
            transacao = sessao.beginTransaction();
            sessao.save(cliente);
            transacao.commit();
            return true;
        } catch(HibernateException erro){
            return false;
        }
    }
    
    public boolean excluir(Cliente cliente){
        try{
            sessao = HibernateUtil.getSessionFactory().openSession();
            transacao = sessao.beginTransaction();
            sessao.delete(cliente);
            transacao.commit();
            return true;
        }catch(HibernateException erro){
            return false;
        }        
    }
    
    public boolean atualizar(Cliente cliente){
        try{
            sessao = HibernateUtil.getSessionFactory().openSession();
            transacao = sessao.beginTransaction();
            sessao.update(cliente);
            transacao.commit();
            return true;
        } catch(HibernateException erro){
            return false;
        }
    }
}
