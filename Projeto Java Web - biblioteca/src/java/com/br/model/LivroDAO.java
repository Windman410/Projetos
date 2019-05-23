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
 * @author mamãe
 */
public class LivroDAO {
    private Session sessao;
    private Transaction transacao;
    private List<Livro> listaLivros;

    public List<Livro> getListaLivros() {
        return listaLivros;
    }

    public void setListaLivros(List<Livro> listaLivros) {
        this.listaLivros = listaLivros;
    }
    
    public List<Livro> listaTodosLivros(){
        sessao = HibernateUtil.getSessionFactory().openSession();
        transacao = sessao.beginTransaction();
        String sql = "SELECT * FROM livro";
        SQLQuery consulta = sessao.createSQLQuery(sql);
        consulta.addEntity(Livro.class);
        listaLivros = consulta.list();
        transacao.commit();
        return listaLivros;
    }
    
    public boolean salvar(Livro livro){
        try{
            sessao = HibernateUtil.getSessionFactory().openSession();
            transacao = sessao.beginTransaction();
            sessao.save(livro);
            transacao.commit();
            return true;
        } catch(HibernateException erro){
            return false;
        }
    }
    
    public boolean excluir(Livro livro){
        try{
            sessao = HibernateUtil.getSessionFactory().openSession();
            transacao = sessao.beginTransaction();
            sessao.delete(livro);
            transacao.commit();
            return true;
        }catch(HibernateException erro){
            return false;
        }        
    }
    
    public boolean atualizar(Livro livro){
        try{
            sessao = HibernateUtil.getSessionFactory().openSession();
            transacao = sessao.beginTransaction();
            sessao.update(livro);
            transacao.commit();
            return true;
        } catch(HibernateException erro){
            return false;
        }
    }
}
