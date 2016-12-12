<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PetSureFileUpload.Views.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" data-ng-app="app">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <div class="container" ng-view>
    
    </div>

    <script src="Scripts/angular.min.js"></script>
    <script src="Scripts/jquery-1.9.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script> 
    <script src="Scripts/angular-route.min.js"></script>
    <script src="Scripts/angular.min.js"></script> 
    <script src="app/app.js"></script>
    <script src="app/directive/ngFileSelect.js"></script>
    <script src="app/controllers/uploadController.js"></script>
    <script src="app/services/appFactory.js"></script>
    <script src="app/services/fileReader.js"></script>
</body>
</html>
