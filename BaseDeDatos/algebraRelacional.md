# Samuel Acevedo - A01026893 - Tarea Algebra Relacional 

## Se dispone de una Base de Datos RELACIONAL para un torneo internacional compuesto de diversas competencias. El esquema de la base de datos es el siguiente:

• COMPETENCIA (NombreCompetencia: STRING, NumPtos: INTEGER, Tipo: STRING)

Una competencia de un cierto TIPO, se identifica por su nombre NOMBRECOMPETENCIA y aporta un cierto número de puntos NUMPTOS.


• PARTICIPANTE ( Número: INTEGER, Apellidos: STRING, Nombre: STRING, Nacionalidad: STRING)

Una persona que participa en el torneo es identificada por un número de participante NUMERO y se registra con sus APELLIDOS, su NOMBRE y su NACIONALIDAD.


• PUNTOSACUMULADOS(Número: INTEGER, Puntos: INTEGER )

Todo participante identificado por NUMERO acumula un número de puntos PUNTOS durante el torneo.


• CLASIFICACION(NombreCompetencia: STRING, Número: INTEGER, Lugar: INTEGER)

Para la competencia de nombre NOMBRECOMPETENCIA, el participante identificado con el número NUMERO fue clasificado en el lugar LUGAR.

### Tomando en cuenta lo anterior, escriba en álgebra relacional las siguientes consultas:

1. Apellidos y nombre de los participantes de nacionalidad mexicana.
    
    - $\Pi$ Apellidos, Nombre ($^\sigma$ Nacionalidad = "Mexicana"(PARTICIPANTE))

2. Apellidos, nombre y puntos acumulados de los participantes de USA.

    - $\Pi$ Apellidos, Nombre, Puntos ($^\sigma$ Nacionalidad = "Estadounidense" (PARICIPANTE $\bowtie$ PUNTOSACUMULADOS))

3. Apellidos y nombre de los participantes que se clasificaron en primer lugar en al menos una competencia.

    - $\Pi$ Apellidos, Nombre ($^\sigma$ Lugar = 1 (PARTICIPANTE $\bowtie$ CLASIFICACION))

4. Nombre de las competencias en las que intervinieron los participantes mexicanos.

    - $\Pi$ NombreCompetencia ($^\sigma$ Nacionalidad = "Mexicana" (PARTICIPANTE $\bowtie$ CLASIFICACION))

5. Apellidos y nombre de los participantes que nunca se clasificaron en primer lugar en alguna competencia.

    - $\Pi$ Apellidos, Nombre ($^\sigma$ Lugar $\not =$ 1 (PARTICIPANTE $\bowtie$ CLASIFICACION))

6. Apellidos y nombre de los participantes siempre se clasificaron en alguna competencia.

    - R1 = $\Pi$ Apellidos, Nombre (PARTICIPANTE)

    - R2 = $\Pi$ Apellidos, Nombre ($^\sigma$ Lugar $< $ 3 (PARTICIPANTE $\bowtie$ CLASIFIACION))

    - R1 - R2

    O también puede ser:

    -  $\Pi$ Apellidos, Nombre ($^\sigma$ Lugar $\geq $ 3 (PARTICIPANTE $\bowtie$ CLASIFIACION))


7. Nombre de la competencia que aporta el máximo de puntos.

    - $\Pi$ NombreCompetencia ($^\sigma$ max(Puntos)(PUNTOSACUMULADOS))

8. Países (nacionalidades) que participaron en todas las competencias.

    - $\Pi$ Nacionalidad ((PARTICIPANTE) $\div$ ($\Pi$ Nacionalidad(PARTICIPANTE)) $\bowtie$ (CLASIFICACION))

    Debo de decir que esta realmente si me confundió, supuse que la nacionalidad se podría sacar dividiendo estas entre los participantes y después compararlas con la tabla de CLASIFICACION para encontrar todas aquellas que estuvieron en todas las competencias. Pero no estoy seguro de que esté bien.