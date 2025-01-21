pipeline{
    agent any
    environment{
       DOTNET_ROOT = '/usr/local/share/dotnet' // Path to the .NET SDK
       PATH = "${DOTNET_ROOT}:/bin:/usr/bin:/opt/homebrew/bin:${env.PATH}" // Ensure DOTNET_ROOT is added to PATH
    }
    stages{
        stage('Checkout'){
            steps{
                echo 'Checking out the code'
                git branch: 'main', url:'https://github.com/AbubakerNaji/Day2.git'
                echo 'Checking out the code'
            }
        }
        stage('Restore'){
                 steps{
            echo 'Restoring the app'
                sh 'cd $WORKSPACE/secondApp'

         sh 'dotnet restore'
         echo 'Done restoring the app'
                 }
        }
        stage('Build'){
            steps{
                echo 'Building the app'
                sh 'dotnet build'
                echo 'Done building the app'
            }
        }
        stage('Run'){
            steps{
                echo 'Running the app'
                sh 'dotnet run'
                echo 'Done running the app'
            }
        }
    }
    post
{
    success{
        echo 'The app has been built successfully'
    }
    failure{
        echo 'The app has failed to build'
    }
}
}
