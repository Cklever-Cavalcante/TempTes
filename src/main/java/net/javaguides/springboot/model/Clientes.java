package net.javaguides.springboot.model;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "clientes")
public class Clientes {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id_cliente;

    @Column(name = "nome")
    private String nome;

    @Column(name = "telefone")
    private String telefone;

    @Column(name = "cidade_reside")
    private String cidadeReside;
    
    @Column(name = "uf_reside")
    private String ufReside;
    
    @Column(name = "email")
    private String email;

    @Column(name = "pais_reside")
    private String paisReside;

    @Column(name = "id_pacote")
    private String id_pacote;

    
	public Clientes() {
		
	}
	
	public Clientes(String nome, String telefone, String cidadeReside, String ufReside, String email, String paisReside, String id_pacote) {
		super();
		this.nome = nome;
		this.telefone = telefone;
		this.cidadeReside = cidadeReside;
		this.ufReside = ufReside;
		this.email = email;
		this.paisReside = paisReside;
		this.id_pacote = id_pacote;
	}
	public long getId_cliente() {
		return id_cliente;
	}
	public void setId_cliente(long id_cliente) {
		this.id_cliente = id_cliente;
	}
	
	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getTelefone() {
		return telefone;
	}

	public void setTelefone(String telefone) {
		this.telefone = telefone;
	}

	public String getCidadeReside() {
		return cidadeReside;
	}

	public void setCidadeReside(String cidadeReside) {
		this.cidadeReside = cidadeReside;
	}

	public String getUfReside() {
		return ufReside;
	}

	public void setUfReside(String ufReside) {
		this.ufReside = ufReside;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getPaisReside() {
		return paisReside;
	}

	public void setPaisReside(String paisReside) {
		this.paisReside = paisReside;
	}

	public String getId_pacote() {
		return id_pacote;
	}

	public void setId_pacote(String id_pacote) {
		this.id_pacote = id_pacote;
	}
	
}
