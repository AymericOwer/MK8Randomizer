with open('gliders.csv', 'r') as csv_file:
    # Lire le contenu du fichier
    csv_data = csv_file.read()

# Diviser le contenu en lignes
lines = csv_data.split('\n')

# Diviser chaque ligne en valeurs séparées par des virgules
for line in lines:
    # Ignorer les lignes vides
    if not line:
        continue
    
    # Diviser la ligne en valeurs
    values = line.split(',')

    # Extraire les valeurs des colonnes
    name = values[0]
    acceleration = values[1]
    weight = values[2]

    # Écrire les informations dans "command.txt" séparées par des tirets
    with open('gliders.txt', 'a') as txt_file:
        txt_file.write(f"new Glider(\"{name}\", \"url\", {weight}, {acceleration}),\n")

print("Glider, done")

with open('wheels.csv', 'r') as csv_file:
    # Lire le contenu du fichier
    csv_data = csv_file.read()

# Diviser le contenu en lignes
lines = csv_data.split('\n')

# Diviser chaque ligne en valeurs séparées par des virgules
for line in lines:
    # Ignorer les lignes vides
    if not line:
        continue
    
    # Diviser la ligne en valeurs
    values = line.split(',')

    # Extraire les valeurs des colonnes
    name = values[0]
    acceleration = values[1]
    weight = values[2]

    # Écrire les informations dans "command.txt" séparées par des tirets
    with open('wheels.txt', 'a') as txt_file:
        txt_file.write(f"new Wheel(\"{name}\", \"url\", {weight}, {acceleration}),\n")

print("Wheels, done")

with open('vehicules.csv', 'r') as csv_file:
    # Lire le contenu du fichier
    csv_data = csv_file.read()

# Diviser le contenu en lignes
lines = csv_data.split('\n')

# Diviser chaque ligne en valeurs séparées par des virgules
for line in lines:
    # Ignorer les lignes vides
    if not line:
        continue
    
    # Diviser la ligne en valeurs
    values = line.split(',')

    # Extraire les valeurs des colonnes
    name = values[0]
    acceleration = values[1]
    weight = values[2]

    # Écrire les informations dans "command.txt" séparées par des tirets
    with open('vehicules.txt', 'a') as txt_file:
        txt_file.write(f"new Vehicule(\"{name}\", \"url\",true, {weight}, {acceleration}),\n")

print("Vehicules, done")

with open('characters.csv', 'r') as csv_file:
    # Lire le contenu du fichier
    csv_data = csv_file.read()

# Diviser le contenu en lignes
lines = csv_data.split('\n')

# Diviser chaque ligne en valeurs séparées par des virgules
for line in lines:
    # Ignorer les lignes vides
    if not line:
        continue
    
    # Diviser la ligne en valeurs
    values = line.split(',')

    # Extraire les valeurs des colonnes
    name = values[0]
    acceleration = values[1]
    weight = values[2]

    # Écrire les informations dans "command.txt" séparées par des tirets
    with open('characters.txt', 'a') as txt_file:
        txt_file.write(f"new Character(\"{name}\", \"url\", {weight}, {acceleration}, false),\n")

print("characters, done")