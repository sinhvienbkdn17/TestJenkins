pipeline {
  agent {
    docker {
      image 'ubuntu '
    }

  }
  stages {
    stage('Build') {
      agent {
        docker {
          image 'ubuntu'
        }

      }
      steps {
        echo 'Build Scucces'
      }
    }
  }
}