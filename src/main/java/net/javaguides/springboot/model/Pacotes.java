package net.javaguides.springboot.model;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "pacotes")
public class Pacotes {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id_pacote;

    @Column(name = "num_acompanhantes")
    private String numAcompanhantes;

    @Column(name = "hospedagem_sim_nao")
    private String hospedagemSimNao;

    @Column(name = "preco")
    private String preco;
    
    @Column(name = "data_ida")
    private String dataIda;
    
    @Column(name = "data_volta")
    private String dataVolta;

    @Column(name = "nome_pacote")
    private String nomePacote;

    @Column(name = "id_cliente")
    private String id_cliente;
    
    @Column(name = "id_destino")
    private String id_destino;
    

	public Pacotes() {
		
	}
	
	public Pacotes(String numAcompanhantes, String hospedagemSimNao, String preco, String dataIda, String dataVolta, String nomePacote, String id_cliente, String id_destino) {
		super();
		this.numAcompanhantes = numAcompanhantes;
		this.hospedagemSimNao = hospedagemSimNao;
		this.preco = preco;
		this.dataIda = dataIda;
		this.dataVolta = dataVolta;
		this.nomePacote = nomePacote;
		this.id_cliente = id_cliente;
		this.id_destino = id_destino;
	}
	public long getId_pacote() {
		return id_pacote;
	}
	public void setId_pacote(long id_pacote) {
		this.id_pacote = id_pacote;
	}
	
	
	public String getNumAcompanhantes() {
		return numAcompanhantes;
	}

	public void setNumAcompanhantes(String numAcompanhantes) {
		this.numAcompanhantes = numAcompanhantes;
	}

	public String getHospedagemSimNao() {
		return hospedagemSimNao;
	}

	public void setHospedagemSimNao(String hospedagemSimNao) {
		this.hospedagemSimNao = hospedagemSimNao;
	}

	public String getPreco() {
		return preco;
	}

	public void setPreco(String preco) {
		this.preco = preco;
	}

	public String getDataIda() {
		return dataIda;
	}

	public void setDataIda(String dataIda) {
		this.dataIda = dataIda;
	}

	public String getDataVolta() {
		return dataVolta;
	}

	public void setDataVolta(String dataVolta) {
		this.dataVolta = dataVolta;
	}

	public String getNomePacote() {
		return nomePacote;
	}

	public void setNomePacote(String nomePacote) {
		this.nomePacote = nomePacote;
	}

	public String getId_cliente() {
		return id_cliente;
	}

	public void setId_cliente(String id_cliente) {
		this.id_cliente = id_cliente;
	}

	public String getId_destino() {
		return id_destino;
	}

	public void setId_destino(String id_destino) {
		this.id_destino = id_destino;
	}
	
	
}
