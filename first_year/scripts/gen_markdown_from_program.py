import os
import subprocess


FOLDERS_PATH = os.path.dirname(os.path.abspath(__file__)).split("scripts")[0]
TEMPLATE_PATH = FOLDERS_PATH + os.sep + "scripts" + os.sep + "template.md"
TEMPLATE = open(TEMPLATE_PATH, "r").read()
FOLDER_NAME = "12_practical"
COMPLETE_PATH = FOLDERS_PATH + os.sep + FOLDER_NAME
MD_PATH = COMPLETE_PATH + os.sep + FOLDER_NAME + ".md"
PDF_PATH = COMPLETE_PATH + os.sep + FOLDER_NAME + ".pdf"

BODY = "{code}\n{output}"


def create_md():
    with open(MD_PATH, "w+", encoding="utf-8") as md_file:
        print("Recorriendo los archivos .cs...")
        for folder in os.listdir(COMPLETE_PATH):
            if folder[0] != "0":
                continue
            folder_path = COMPLETE_PATH + os.sep + folder
            for file in os.listdir(folder_path):
                file_path = folder_path + os.sep + file
                if not os.path.isfile(file_path):
                    continue
                if file.split(".")[1] != "cs":
                    continue
                print(f"Usando el archivo: {file}")
                print("Obteniendo el contenido del archivo...")
                cs_content = open(file_path, encoding="utf-8").read()
                code = f"""Código:\n\n```csharp\n{cs_content}\n```\n"""
                command = f"dotnet run {file_path} --project {folder_path}"
                print(f"Ejecutando el comando: {command}")
                if not "output.txt" in os.listdir(folder_path):
                    output = "Salida:\n\n```\n" + subprocess.run(command, shell=True, stdin=subprocess.DEVNULL, capture_output=True, text=True, encoding="utf-8").stdout + "\n```"
                else:
                    output = "Salida:\n```\n" + open(folder_path + os.sep + "output.txt").read() + "\n```"
                title = "Ejercicio " + folder if folder[0] != "0" else "Ejercicio " + folder[1:]
                body = BODY.format(
                    code=code,
                    output=output
                )
                print("Reemplazando el contenido del template...")
                content = TEMPLATE.format(
                    MD_TITLE=title,
                    BODY=body
                )
                print("Agregando el contenido al archivo final...")
                md_file.write(content)
        print("¡Fin del proceso!")
        print(f"Archivo: {MD_PATH}")


if __name__ == "__main__":
    create_md()
