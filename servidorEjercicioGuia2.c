#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <pthread.h>

int i;
int sockets[100];

// Función para atender a cada cliente
void *AtenderCliente(void *socket) {
    int sock_conn;
    int *s;
    s = (int *)socket;
    sock_conn = *s;

    char peticion[512];
    char respuesta[512];
    int ret;

    while (1) {
        // Recibir la petición del cliente
        ret = read(sock_conn, peticion, sizeof(peticion));
        if (ret <= 0) {
            printf("El cliente se ha desconectado.\n");
            break;
        }
        peticion[ret] = '\0'; // Añadir fin de cadena

        printf("Petición recibida: %s\n", peticion);

        // Procesar la petición
        char *p = strtok(peticion, "/");
        char tipoConversion[5];
        float temperatura;
        
        strcpy(tipoConversion, p); // Obtener el tipo de conversión
        p = strtok(NULL, "/");
        temperatura = atof(p); // Obtener la temperatura

        // Realizar la conversión
        float resultado;
        if (strcmp(tipoConversion, "FtoC") == 0) {
            resultado = (temperatura - 32) * 5 / 9; // Convertir de Fahrenheit a Celsius
            sprintf(respuesta, "Resultado: %.2f C", resultado);
        } else if (strcmp(tipoConversion, "CtoF") == 0) {
            resultado = (temperatura * 9 / 5) + 32; // Convertir de Celsius a Fahrenheit
            sprintf(respuesta, "Resultado: %.2f F", resultado);
        } else {
            sprintf(respuesta, "Tipo de conversión no válido.");
        }

        // Enviar la respuesta al cliente
        write(sock_conn, respuesta, strlen(respuesta));
        printf("Respuesta enviada: %s\n", respuesta);
    }

    // Cerrar el socket al finalizar
    close(sock_conn);
}

int main(int argc, char *argv[]) {
    int sock_conn, sock_listen;
    struct sockaddr_in serv_adr;

    // Abrir el socket
    if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0) {
        printf("Error creando socket\n");
        return 1;
    }

    // Configurar la dirección del servidor
    memset(&serv_adr, 0, sizeof(serv_adr));
    serv_adr.sin_family = AF_INET;
    serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
    serv_adr.sin_port = htons(9050);

    if (bind(sock_listen, (struct sockaddr *)&serv_adr, sizeof(serv_adr)) < 0) {
        printf("Error en el bind\n");
        return 1;
    }

    if (listen(sock_listen, 3) < 0) {
        printf("Error en el listen\n");
        return 1;
    }

    printf("Servidor escuchando en el puerto 9050...\n");
    pthread_t thread;

    for (;;) {
        sock_conn = accept(sock_listen, NULL, NULL);
        printf("Conexión recibida\n");

        // Crear un hilo para atender al cliente
        pthread_create(&thread, NULL, AtenderCliente, &sock_conn);
    }
    return 0;
}


