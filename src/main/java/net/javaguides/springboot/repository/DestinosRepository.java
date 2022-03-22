package net.javaguides.springboot.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import net.javaguides.springboot.model.Destinos;

@Repository
public interface DestinosRepository extends JpaRepository<Destinos, Long>{

}
