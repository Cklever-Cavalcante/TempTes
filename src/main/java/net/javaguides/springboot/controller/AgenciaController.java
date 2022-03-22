package net.javaguides.springboot.controller;

import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import net.javaguides.springboot.exception.ResourceNotFoundException;
import net.javaguides.springboot.model.Clientes;
import net.javaguides.springboot.repository.ClientesRepository;
import net.javaguides.springboot.model.Destinos;
import net.javaguides.springboot.repository.DestinosRepository;
import net.javaguides.springboot.model.Pacotes;
import net.javaguides.springboot.repository.PacotesRepository;


/*===Conexão com o FrontEnd em React Js*/
@CrossOrigin(origins = "http://localhost:3000")
@RestController
@RequestMapping("/api/v1/")
public class AgenciaController {

	@Autowired
	private ClientesRepository clientesRepository;
	@Autowired
	private DestinosRepository destinosRepository;
	@Autowired
	private PacotesRepository pacotesRepository;

/*========================Metodos Listar============================================*/	
	
	// Listar todos os Clientes
		@GetMapping("/clientes")
		public List<Clientes> getAllClientes(){
			return clientesRepository.findAll();
		}
	
		// Listar todos os Destinos
				@GetMapping("/destinos")
				public List<Destinos> getAllDestinos(){
					return destinosRepository.findAll();
				}
				
				// Listar todos os Pacotes
				@GetMapping("/pacotes")
				public List<Pacotes> getAllPacotes(){
					return pacotesRepository.findAll();
				}
		

/*=========================Metodos Criar============================================*/	
	
	// Criar novo Cliente rest api
		@PostMapping("/clientes")
		public Clientes createClientes(@RequestBody Clientes clientes) {
			return clientesRepository.save(clientes);
		}
		
		// Criar novo Destino rest api
		@PostMapping("/destinos")
		public Destinos createDestinos(@RequestBody Destinos destinos) {
			return destinosRepository.save(destinos);
		}
		
		// Criar novo Pacote rest api
		@PostMapping("/pacotes")
		public Pacotes createPacotes(@RequestBody Pacotes pacotes) {
			return pacotesRepository.save(pacotes);
		}

/*==============================Metodos Listar pelo Id======================================================================*/	
		
	// Listar Cliente pelo id rest api
		@GetMapping("/clientes/{id_cliente}")
		public ResponseEntity<Clientes> getClientesById(@PathVariable Long id_cliente) {
			Clientes clientes = clientesRepository.findById(id_cliente)
					.orElseThrow(() -> new ResourceNotFoundException("Employee not exist with id :" + id_cliente));
			return ResponseEntity.ok(clientes);
		}
		
		// Listar Destino pelo id rest api
		@GetMapping("/destinos/{id_destino}")
		public ResponseEntity<Destinos> getDestinosById(@PathVariable Long id_destino) {
			Destinos destinos = destinosRepository.findById(id_destino)
					.orElseThrow(() -> new ResourceNotFoundException("Employee not exist with id :" + id_destino));
			return ResponseEntity.ok(destinos);
		}
		
		// Listar Pacote pelo id rest api
		@GetMapping("/pacotes/{id_pacote}")
		public ResponseEntity<Pacotes> getPacotesById(@PathVariable Long id_pacote) {
			Pacotes pacotes = pacotesRepository.findById(id_pacote)
					.orElseThrow(() -> new ResourceNotFoundException("Employee not exist with id :" + id_pacote));
			return ResponseEntity.ok(pacotes);
		}
	
/*========================Metodos Atualizar=========================================*/	
		
	// Atualizar Cliente rest api
	
		@PutMapping("/clientes/{id_cliente}")
		public ResponseEntity<Clientes> updateClientes(@PathVariable Long id_cliente, @RequestBody Clientes clientesDetails){
			Clientes clientes = clientesRepository.findById(id_cliente)
					.orElseThrow(() -> new ResourceNotFoundException("Employee not exist with id :" + id_cliente));
			
			clientes.setNome(clientesDetails.getNome());
			clientes.setTelefone(clientesDetails.getTelefone());
			clientes.setCidadeReside(clientesDetails.getCidadeReside());
			clientes.setUfReside(clientesDetails.getUfReside());
			clientes.setEmail(clientesDetails.getEmail());
			clientes.setPaisReside(clientesDetails.getPaisReside());
			
			Clientes updatedClientes = clientesRepository.save(clientes);
			return ResponseEntity.ok(updatedClientes);
		}
		
		// Atualizar Destino rest api
		
			@PutMapping("/destinos/{id_destino}")
			public ResponseEntity<Destinos> updateDestinos(@PathVariable Long id_destino, @RequestBody Destinos destinosDetails){
				Destinos destinos = destinosRepository.findById(id_destino)
						.orElseThrow(() -> new ResourceNotFoundException("Employee not exist with id :" + id_destino));
				
				destinos.setCidade(destinosDetails.getCidade());
				destinos.setEstado(destinosDetails.getEstado());
				destinos.setPais(destinosDetails.getPais());
				
				Destinos updatedDestinos = destinosRepository.save(destinos);
				return ResponseEntity.ok(updatedDestinos);
			}
			
			// Atualizar Pacote rest api
			
			@PutMapping("/pacotes/{id_pacote}")
			public ResponseEntity<Pacotes> updatePacotes(@PathVariable Long id_pacote, @RequestBody Pacotes pacotesDetails){
				Pacotes pacotes = pacotesRepository.findById(id_pacote)
						.orElseThrow(() -> new ResourceNotFoundException("Employee not exist with id :" + id_pacote));
				
				pacotes.setNumAcompanhantes(pacotesDetails.getNumAcompanhantes());
				pacotes.setHospedagemSimNao(pacotesDetails.getHospedagemSimNao());
				pacotes.setPreco(pacotesDetails.getPreco());
				pacotes.setDataIda(pacotesDetails.getDataIda());
				pacotes.setDataVolta(pacotesDetails.getDataVolta());
				pacotes.setNomePacote(pacotesDetails.getNomePacote());
				
				Pacotes updatedPacotes = pacotesRepository.save(pacotes);
				return ResponseEntity.ok(updatedPacotes);
			}
	
/*=============================Metodos Deletar========================================================================*/	
		
	// Deletar Cliente rest api
		@DeleteMapping("/clientes/{id_cliente}")
		public ResponseEntity<Map<String, Boolean>> deleteClientes(@PathVariable Long id_cliente){
			Clientes clientes = clientesRepository.findById(id_cliente)
					.orElseThrow(() -> new ResourceNotFoundException("Employee not exist with id :" + id_cliente));
			
			clientesRepository.delete(clientes);
			Map<String, Boolean> response = new HashMap<>();
			response.put("deleted", Boolean.TRUE);
			return ResponseEntity.ok(response);
		}
		
		// Deletar Destino rest api
		@DeleteMapping("/destinos/{id_destino}")
		public ResponseEntity<Map<String, Boolean>> deleteDestinos(@PathVariable Long id_destino){
			Destinos destinos = destinosRepository.findById(id_destino)
					.orElseThrow(() -> new ResourceNotFoundException("Employee not exist with id :" + id_destino));
			
			destinosRepository.delete(destinos);
			Map<String, Boolean> response = new HashMap<>();
			response.put("deleted", Boolean.TRUE);
			return ResponseEntity.ok(response);
		}
		
		// Deletar Pacote rest api
		@DeleteMapping("/pacotes/{id_pacote}")
		public ResponseEntity<Map<String, Boolean>> deletePacotes(@PathVariable Long id_pacote){
			Pacotes pacotes = pacotesRepository.findById(id_pacote)
					.orElseThrow(() -> new ResourceNotFoundException("Employee not exist with id :" + id_pacote));
			
			pacotesRepository.delete(pacotes);
			Map<String, Boolean> response = new HashMap<>();
			response.put("deleted", Boolean.TRUE);
			return ResponseEntity.ok(response);
		}
	
	
}
