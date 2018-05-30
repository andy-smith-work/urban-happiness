pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                echo 'Restore nugets..'
                bat 'c:\\nuget\\nuget.exe restore CompanyInfo.sln'
                echo 'Building..'
                script {
                    def msbuild = tool name: 'MSBuild', type: 'hudson.plugins.msbuild.MsBuildInstallation'
                    bat "${msbuild} CompanyInfo.sln"
                }
//                bat "\"${tool 'MSBuild'}\" CompanyInfo.sln /noautorsp /ds /nologo /t:clean,rebuild /p:Configuration=Debug /v:m /p:VisualStudioVersion=14.0 /clp:Summary;ErrorsOnly;WarningsOnly"
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }

    post {
        success {
            echo 'Pipeline Succeeded'
        }
        failure {
            echo 'Pipeline Failed'
        }
        unstable {
            echo 'Pipeline run marked unstable'
        }
    }
}