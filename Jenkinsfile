pipeline {
agent any

stages {
stage('Build') {
steps {
bat echo 'Restore nugets..'
bat 'nuget restore CompanyInfo.sln'
bat echo 'Building..'
bat "msbuild.exe CompanyInfo.sln /noautorsp /ds /nologo /t:clean,rebuild /p:Configuration=Debug /v:m /p:VisualStudioVersion=14.0 /clp:Summary;ErrorsOnly;WarningsOnly"
}
}
stage('Test') {
steps {
bat echo 'Testing..'
}
}
stage('Deploy') {
steps {
bat echo 'Deploying....'
}
}
}

post {
success {
bat echo 'Pipeline Succeeded'
}
failure {
bat echo 'Pipeline Failed'
}
unstable {
bat echo 'Pipeline run marked unstable'
}

}
}