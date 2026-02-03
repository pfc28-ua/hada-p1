Pablo Fernandez Cabezas

Práctica 1: Uso de git

P1. ¿Qué crees que significa la opción -n en el comando revert? La opción -n (o --no-commit) indica a git que aplique los cambios necesarios para deshacer el commit seleccionado en el directorio de trabajo y en el índice, pero sin crear automáticamente el nuevo commit de confirmación. Esto permite al usuario revisar los cambios o realizar modificaciones adicionales antes de confirmar la reversión manualmente.



P2. ¿Qué cambios se han producido al ejecutar el comando reset? Al ejecutar git reset --hard, el puntero de la rama actual (HEAD) se mueve al commit especificado y el directorio de trabajo se actualiza para coincidir exactamente con ese estado. Cualquier cambio no confirmado o commit posterior al punto elegido se elimina permanentemente del directorio de trabajo y del historial de la rama.





P3. ¿Qué diferencias observas entre revert y reset? 
La principal diferencia es cómo afectan al historial del repositorio:


Revert: Crea un nuevo commit que deshace los cambios de un commit anterior, manteniendo la historia intacta y permitiendo ver que algo fue deshecho. Es más seguro para ramas compartidas.




Reset: Mueve el puntero de la rama hacia atrás en el tiempo, borrando los commits intermedios de la historia de esa rama. Es una operación destructiva para el historial.





P4. ¿Qué diferencias observas entre merge y rebase? 


Merge (Mezcla): Combina dos ramas creando un nuevo "commit de fusión" (merge commit) que une las historias de ambas. Conserva el historial tal y como sucedió, incluyendo las bifurcaciones.





Rebase (Rebasar): Mueve o "vuelve a escribir" los commits de una rama para que parezcan realizados linealmente sobre la punta de otra rama. Esto resulta en un historial mucho más limpio y lineal, sin commits de fusión adicionales.