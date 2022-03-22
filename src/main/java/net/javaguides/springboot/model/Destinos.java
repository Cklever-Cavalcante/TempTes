package net.javaguides.springboot.model;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "destinos")
public class Destinos {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id_destino;

    @Column(name = "cidade")
    private String cidade;

    @Column(name = "estado")
    private String estado;

    @Column(name = "pais")
    private String pais;
    
    @Column(name = "id_pacote")
    private String id_pacote;
    

	public Destinos() {
		
	}
	
	public Destinos(String cidade, String estado, String pais, String id_pacote) {
		super();
		this.cidade = cidade;
		this.estado = estado;
		this.pais = pais;
		this.id_pacote = id_pacote;
	}
	public long getId_destino() {
		return id_destino;
	}
	public void setId_destino(long id_destino) {
		this.id_destino = id_destino;
	}
	
	
	public String getCidade() {
		return cidade;
	}

	public void setCidade(String cidade) {
		this.cidade = cidade;
	}

	public String getEstado() {
		return estado;
	}

	public void setEstado(String estado) {
		this.estado = estado;
	}

	public String getPais() {
		return pais;
	}

	public void setPais(String pais) {
		this.pais = pais;
	}

	public String getId_pacote() {
		return id_pacote;
	}

	public void setId_pacote(String id_pacote) {
		this.id_pacote = id_pacote;
	}
	
}
