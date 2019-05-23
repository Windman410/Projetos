/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.br.control;

import com.br.model.*;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import javax.inject.Named;
import javax.enterprise.context.SessionScoped;
import java.io.Serializable;
import java.io.UnsupportedEncodingException;
import java.nio.file.Files;
import java.security.NoSuchAlgorithmException;
import java.util.List;
import javax.annotation.ManagedBean; 	
import javax.faces.context.ExternalContext;
import javax.faces.context.FacesContext;
import javax.servlet.ServletContext;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.Part;
import org.primefaces.event.FileUploadEvent;

/**
 *
 * @author mamãe
 */
@ManagedBean
@Named(value = "livroBean")
@SessionScoped
public class LivroBean implements Serializable {

    private Livro livro = new Livro();
    private LivroDAO livroDAO = new LivroDAO();
    private List<Livro> listaLivros;
    private Part file;

    public Livro getLivro() {
        return livro;
    }

    public void setLivro(Livro livro) {
        this.livro = livro;
    }

    public LivroDAO getLivroDAO() {
        return livroDAO;
    }

    public void setLivroDAO(LivroDAO livroDAO) {
        this.livroDAO = livroDAO;
    }
    
    public List<Livro> getListaLivros() {
        listaLivros = livroDAO.listaTodosLivros();
        return listaLivros;
    }

    public void setListaLivros(List<Livro> listaLivros) {
        this.listaLivros = listaLivros;
    } 
    
    public void carregarLivro(Livro li){
        this.livro = li;    
    }

    public Part getFile() {
        return file;
    }

    public void setFile(Part file) {
        this.file = file;
    }
    
    public String salvar() throws NoSuchAlgorithmException, UnsupportedEncodingException{
        if (livroDAO.salvar(livro))
            return "livros";
        else
            return "erro";
    }
    
    public String excluir(Livro livro){
        if(livroDAO.excluir(livro))
            return "livros";
        else
            return "erro";
    }
        
    public String atualizar()throws NoSuchAlgorithmException, UnsupportedEncodingException{
        if(livroDAO.atualizar(livro))
            return "livros";
        else
            return "erro";
    } // +getter+setter    
}
