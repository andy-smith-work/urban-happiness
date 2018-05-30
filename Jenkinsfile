pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        echo 'Restore nuget packages...'
        bat 'c:\\nuget\\nuget.exe restore CompanyInfo.sln'
        echo 'Building...'
        script {
          def msbuild = tool name: 'MSBuild', type: 'hudson.plugins.msbuild.MsBuildInstallation'
          bat "${msbuild} CompanyInfo.sln /p:VisualStudioVersion=14.0 /t:clean,rebuild /p:Configuration=Debug"
        }

      }
    }
    stage('Test') {
      steps {
        echo 'Testing...'
        bat "\"${tool 'MSTest'}\" /testcontainer:CompanyInfo.Tests\\bin\\Debug\\CompanyInfo.Tests.dll"
        mstest testResultsFile:"**/*.trx", keepLongStdio: true
      }
    }
    stage('Deploy') {
      steps {
        echo 'Deploying...'
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