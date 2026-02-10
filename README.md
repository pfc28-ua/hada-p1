P1: Nombre de usuario en GitHub: [pfc28-ua]

P2: URL del repositorio: [https://github.com/pfc28-ua/hada-p1]

P3: Comando para asociar el repositorio local con el remoto: git remote add origin [https://github.com/pfc28-ua/hada-p1]

P4: Comando para subir los cambios por primera vez: git push -u origin master

P5: Comando para descargar los cambios del servidor que no están en local: git pull origin master

P6: ¿Qué sucede al intentar un push si hay cambios en el servidor que no tenemos en local? Git rechaza la operación informando que el repositorio remoto contiene trabajo que no existe localmente ("fetch first").

P7: Pasos para solucionar un conflicto: 
1. Ejecutar git pull para fusionar los cambios.
2. Abrir el archivo con conflictos y decidir qué cambios mantener (borrando las marcas <<<<, ====, >>>>).
3. Hacer git add, git commit y finalmente git push.
