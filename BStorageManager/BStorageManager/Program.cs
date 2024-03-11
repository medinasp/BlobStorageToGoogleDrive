// See https://aka.ms/new-console-template for more information
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Util.Store;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Http;
using Google.Apis.Services;
using static Google.Apis.Drive.v3.FilesResource;
using Google.Apis.Upload;


//subindo arquivos
//Console.WriteLine("Starting...");
//var blobStorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=blobstoragedemed;AccountKey=rG7Pw7GxDLYIPSMfTsC3osMXTeNoCrYoDMgJZEG194BXdpBx6AQCuwfZwHxDQEkh8lvpxTFRWdRj+AStYbxLVQ==;EndpointSuffix=core.windows.net";
//var blobStorageContainerName = "filemanager";
//var container = new BlobContainerClient(blobStorageConnectionString, blobStorageContainerName);

//var blob = container.GetBlobClient("detran_taxas_impostos.pdf");

//var stream = File.OpenRead("detran_taxas_impostos.pdf");
//await blob.UploadAsync(stream);

//Console.WriteLine("Success upload");




//baixando arquivo específico:
//string blobStorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=blobstoragedemed;AccountKey=rG7Pw7GxDLYIPSMfTsC3osMXTeNoCrYoDMgJZEG194BXdpBx6AQCuwfZwHxDQEkh8lvpxTFRWdRj+AStYbxLVQ==;EndpointSuffix=core.windows.net";
//string blobStorageContainerName = "filemanager";
//string blobName = "detran_taxas_impostos.pdf";
//string localFilePath = "detran_taxas_impostos_downloaded.pdf";

//// Criar um BlobServiceClient para interagir com o Blob Storage
//BlobServiceClient blobServiceClient = new BlobServiceClient(blobStorageConnectionString);

//// Obter uma referência ao contêiner de armazenamento
//BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(blobStorageContainerName);

//// Verificar se o contêiner existe
//if (!await containerClient.ExistsAsync())
//{
//    Console.WriteLine($"O contêiner '{blobStorageContainerName}' não existe.");
//    return;
//}

//// Obter uma referência ao blob de destino
//BlobClient blobClient = containerClient.GetBlobClient(blobName);

//// Verificar se o blob existe
//if (!await blobClient.ExistsAsync())
//{
//    Console.WriteLine($"O blob '{blobName}' não existe no contêiner '{blobStorageContainerName}'.");
//    return;
//}

//// Fazer o download do blob para um arquivo local
//await blobClient.DownloadToAsync(localFilePath);

//Console.WriteLine($"O arquivo '{blobName}' foi baixado para '{localFilePath}' com sucesso.");



//baixando todos arquivos de um storage:
//string blobStorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=blobstoragedemed;AccountKey=rG7Pw7GxDLYIPSMfTsC3osMXTeNoCrYoDMgJZEG194BXdpBx6AQCuwfZwHxDQEkh8lvpxTFRWdRj+AStYbxLVQ==;EndpointSuffix=core.windows.net";
//string blobStorageContainerName = "filemanager";
//string localFolderPath = @"C:\1A\Tec\C#\BStorageManager\BStorageManager\BStorageManager\bin\Debug\net7.0\"; 

//// Criar um BlobServiceClient para interagir com o Blob Storage
//BlobServiceClient blobServiceClient = new BlobServiceClient(blobStorageConnectionString);

//// Obter uma referência ao contêiner de armazenamento
//BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(blobStorageContainerName);

//// Verificar se o contêiner existe
//if (!await containerClient.ExistsAsync())
//{
//    Console.WriteLine($"O contêiner '{blobStorageContainerName}' não existe.");
//    return;
//}

//await foreach (BlobItem blobItem in containerClient.GetBlobsAsync())
//{
//    // Obter uma referência ao blob
//    BlobClient blobClient = containerClient.GetBlobClient(blobItem.Name);

//    // Fazer o download do blob para um arquivo local
//    string localFilePath = Path.Combine(localFolderPath, blobItem.Name);
//    await blobClient.DownloadToAsync(localFilePath);

//    Console.WriteLine($"O arquivo '{blobItem.Name}' foi baixado para '{localFilePath}' com sucesso.");
//}

//Console.WriteLine("Todos os arquivos foram baixados com sucesso.");



//Baixando somente o primeiro da lista do blob storage
//string blobStorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=blobstoragedemed;AccountKey=rG7Pw7GxDLYIPSMfTsC3osMXTeNoCrYoDMgJZEG194BXdpBx6AQCuwfZwHxDQEkh8lvpxTFRWdRj+AStYbxLVQ==;EndpointSuffix=core.windows.net";
//string blobStorageContainerName = "filemanager";
//string localFolderPath = @"C:\1A\Tec\C#\BStorageManager\BStorageManager\BStorageManager\bin\Debug\net7.0\";

//// Criar um BlobServiceClient para interagir com o Blob Storage
//BlobServiceClient blobServiceClient = new BlobServiceClient(blobStorageConnectionString);

//// Obter uma referência ao contêiner de armazenamento
//BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(blobStorageContainerName);

//// Verificar se o contêiner existe
//if (!await containerClient.ExistsAsync())
//{
//    Console.WriteLine($"O contêiner '{blobStorageContainerName}' não existe.");
//    return;
//}

//// Obter a lista de blobs no contêiner (não está dando certo
//await foreach (BlobItem blobItem in containerClient.GetBlobsAsync())
//{
//    // Obter uma referência ao blob
//    BlobClient blobClient = containerClient.GetBlobClient(blobItem.Name);

//    // Fazer o download do blob para um arquivo local
//    string localFilePath = Path.Combine(localFolderPath, blobItem.Name);
//    await blobClient.DownloadToAsync(localFilePath);

//    Console.WriteLine($"O arquivo '{blobItem.Name}' foi baixado para '{localFilePath}' com sucesso.");
//    break; // Apenas baixar o primeiro arquivo e sair do loop
//}

//Console.WriteLine("Download completo.");


//Incluindo datas na verificação
//string blobStorageContainerUrl = "https://blobstoragedemed.blob.core.windows.net/filemanager";

//// Abrir o navegador padrão com o URL do contêiner do Azure Blob Storage
//string blobStorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=gerenciadordegravacoes;AccountKey=BbkLPnBPXf815YVA5wiEnYBe1jjlzmrBFYF6UFWY19J6bxOZhi/02j5kvmr/uiSBXwMQPQXAKE6s+AStSu5OMg==;EndpointSuffix=core.windows.net";
//string blobStorageContainerName = "pabx2";

//// Criar um BlobServiceClient para interagir com o Blob Storage
//BlobServiceClient blobServiceClient = new BlobServiceClient(blobStorageConnectionString);

//// Obter uma referência ao contêiner de armazenamento
//BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(blobStorageContainerName);

//// Verificar se o contêiner existe
//if (!await containerClient.ExistsAsync())
//{
//    Console.WriteLine($"O contêiner '{blobStorageContainerName}' não existe.");
//    return;
//}

//// Obter o primeiro blob na lista de blobs no contêiner
//await foreach (BlobItem blobItem in containerClient.GetBlobsAsync())
//{
//    Console.WriteLine($"Nome do arquivo: {blobItem.Name}");

//    // Obter as propriedades do blob para acessar a data/hora de modificação
//    BlobClient blobClient = containerClient.GetBlobClient(blobItem.Name);
//    var properties = await blobClient.GetPropertiesAsync();
//    var lastModified = properties.Value.LastModified;

//    Console.WriteLine($"Data/Hora de modificação: {lastModified}");
//    break; // Apenas imprimir o primeiro arquivo e sair do loop
//}










//conexao google drive
//string[] scopes = { DriveService.Scope.Drive };
//string applicationName = "BStorageManager";

//// Carregar as credenciais do arquivo JSON
//GoogleCredential credential;
//using (var stream = new FileStream(@"C:\Users\Eneias\Downloads\alien-array-416816-224578aafb8d.json", FileMode.Open, FileAccess.Read))
//{
//    credential = GoogleCredential.FromStream(stream)
//        .CreateScoped(scopes);
//}

//// Inicializar o serviço do Google Drive
//var service = new DriveService(new BaseClientService.Initializer()
//{
//    HttpClientInitializer = credential,
//    ApplicationName = applicationName,
//});

//// Definir o ID do diretório de destino (substitua pelo seu ID de diretório)
//string directoryId = "1vb31281NH61Fksuv1LFHLIGCJYgcGmli";

//// Definir o nome e o caminho local do arquivo a ser carregado
//string fileName = "detran_taxas_impostos.pdf";
//string filePath = Path.Combine(@"C:\1A\Tec\C#\BStorageManager\BStorageManager\BStorageManager\bin\Debug\net7.0", fileName);

//// Criar o arquivo de metadados
//var fileMetadata = new Google.Apis.Drive.v3.Data.File()
//{
//    Name = fileName,
//    Parents = new[] { directoryId } // Definir o ID do diretório de destino
//};

//// Fazer o upload do arquivo para o Google Drive
//using (var stream = new FileStream(filePath, FileMode.Open))
//{
//    var request = service.Files.Create(fileMetadata, stream, "application/pdf");
//    request.Upload();
//}

//Console.WriteLine("Arquivo enviado com sucesso para o Google Drive.");



////subindo todos arquivos ano 2024:
//string[] scopes = { DriveService.Scope.Drive };
//string applicationName = "BStorageManager";

//// Carregar as credenciais do arquivo JSON
//GoogleCredential credential;
//using (var stream = new FileStream(@"C:\Users\Eneias\Downloads\alien-array-416816-224578aafb8d.json", FileMode.Open, FileAccess.Read))
//{
//    credential = GoogleCredential.FromStream(stream)
//        .CreateScoped(scopes);
//}

//// Inicializar o serviço do Google Drive
//var service = new DriveService(new BaseClientService.Initializer()
//{
//    HttpClientInitializer = credential,
//    ApplicationName = applicationName,
//});

//// Definir o ID do diretório de destino (substitua pelo seu ID de diretório)
//string directoryId = "1vb31281NH61Fksuv1LFHLIGCJYgcGmli";

//// Definir o caminho da pasta local
//string folderPath = @"C:\1A\Tec\C#\BStorageManager\BStorageManager\BStorageManager\bin\Debug\net7.0";

//// Obter a lista de arquivos na pasta
//string[] files = Directory.GetFiles(folderPath);

//// Para cada arquivo na pasta
//foreach (string filePath in files)
//{
//    // Obter informações sobre o arquivo
//    FileInfo fileInfo = new FileInfo(filePath);

//    // Verificar se o arquivo foi criado em 2024
//    if (fileInfo.CreationTime.Year == 2024)
//    {
//        // Criar o arquivo de metadados
//        var fileMetadata = new Google.Apis.Drive.v3.Data.File()
//        {
//            Name = fileInfo.Name,
//            Parents = new[] { directoryId } // Definir o ID do diretório de destino
//        };

//        // Fazer o upload do arquivo para o Google Drive
//        using (var stream = new FileStream(filePath, FileMode.Open))
//        {
//            var request = service.Files.Create(fileMetadata, stream, "application/pdf");
//            request.Upload();
//        }

//        Console.WriteLine($"Arquivo {fileInfo.Name} enviado com sucesso para o Google Drive.");
//    }
//}

//Console.WriteLine("Todos os arquivos foram enviados com sucesso para o Google Drive.");




////Credenciais de serviço para autenticar com a API do Google Drive
//GoogleCredential credential;
//using (var stream = new System.IO.FileStream(@"C:\Users\Eneias\Downloads\alien-array-416816-224578aafb8d.json", System.IO.FileMode.Open, System.IO.FileAccess.Read))
//{
//    credential = GoogleCredential.FromStream(stream)
//        .CreateScoped(new[] { DriveService.Scope.Drive });
//}

//// Criar o serviço Google Drive
//var service = new DriveService(new BaseClientService.Initializer()
//{
//    HttpClientInitializer = credential,
//    ApplicationName = "BStorageManager"
//});

//// ID da pasta no Google Drive
//string folderId = "1vb31281NH61Fksuv1LFHLIGCJYgcGmli";

//// Listar arquivos na pasta
//var request = service.Files.List();
//request.Q = $"'{folderId}' in parents";
//var response = await request.ExecuteAsync();

//// Exibir lista de arquivos
//Console.WriteLine("Arquivos na pasta:");
//foreach (var file in response.Files)
//{
//    Console.WriteLine($"{file.Name} ({file.Id})");
//}




//Pegando arquivos do Storage e enviando diretamente para o google drive
string blobStorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=blobstoragedemed;AccountKey=rG7Pw7GxDLYIPSMfTsC3osMXTeNoCrYoDMgJZEG194BXdpBx6AQCuwfZwHxDQEkh8lvpxTFRWdRj+AStYbxLVQ==;EndpointSuffix=core.windows.net";
string blobStorageContainerName = "filemanager";
string localFolderPath = @"C:\1A\Tec\C#\BStorageManager\BStorageManager\BStorageManager\bin\Debug\net7.0\";
string googleDriveDirectoryId = "1vb31281NH61Fksuv1LFHLIGCJYgcGmli"; // ID do diretório de destino no Google Drive

// Criar um BlobServiceClient para interagir com o Blob Storage
BlobServiceClient blobServiceClient = new BlobServiceClient(blobStorageConnectionString);

// Obter uma referência ao contêiner de armazenamento
BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(blobStorageContainerName);

// Verificar se o contêiner existe
if (!await containerClient.ExistsAsync())
{
    Console.WriteLine($"O contêiner '{blobStorageContainerName}' não existe.");
    return;
}

var driveService = GetDriveService(); // Método para obter o serviço do Google Drive

await foreach (BlobItem blobItem in containerClient.GetBlobsAsync())
{
    // Obter uma referência ao blob
    BlobClient blobClient = containerClient.GetBlobClient(blobItem.Name);

    // Fazer o download do blob para um arquivo local
    string localFilePath = Path.Combine(localFolderPath, blobItem.Name);
    await blobClient.DownloadToAsync(localFilePath);

    Console.WriteLine($"O arquivo '{blobItem.Name}' foi baixado para '{localFilePath}' com sucesso.");

    // Fazer o upload do arquivo para o Google Drive
    using (var stream = new FileStream(localFilePath, FileMode.Open))
    {
        var fileMetadata = new Google.Apis.Drive.v3.Data.File()
        {
            Name = blobItem.Name,
            Parents = new[] { googleDriveDirectoryId }
        };

        var request = driveService.Files.Create(fileMetadata, stream, "application/octet-stream");
        request.Upload();
    }

    Console.WriteLine($"O arquivo '{blobItem.Name}' foi enviado com sucesso para o Google Drive.");
}

Console.WriteLine("Todos os arquivos foram baixados e enviados com sucesso para o Google Drive.");

// Método para obter o serviço do Google Drive
DriveService GetDriveService()
{
    string[] scopes = { DriveService.Scope.Drive };
    string applicationName = "BStorageManager";

    GoogleCredential credential;
    using (var stream = new FileStream(@"C:\Users\Eneias\Downloads\alien-array-416816-224578aafb8d.json", FileMode.Open, FileAccess.Read))
    {
        credential = GoogleCredential.FromStream(stream)
            .CreateScoped(scopes);
    }

    var service = new DriveService(new BaseClientService.Initializer()
    {
        HttpClientInitializer = credential,
        ApplicationName = applicationName,
    });

    return service;
}
