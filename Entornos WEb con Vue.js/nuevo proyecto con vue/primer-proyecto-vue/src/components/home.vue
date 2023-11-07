<template>
    <div class="main-container">
      <main class="main">
        <h1 class="main__title">Bienvenido a UNAN León</h1>
        <p class="main__description">
          La Universidad Nacional Autónoma de Nicaragua, León (UNAN León) es una institución pública de educación superior ubicada en la histórica ciudad de León, Nicaragua. Fundada en 1813, es una de las universidades más antiguas de América Latina.
        </p>
        <p class="main__description">
          Ofrecemos una amplia variedad de programas académicos en áreas como ciencias, humanidades, ingeniería, medicina y muchas otras disciplinas. Nuestra misión es proporcionar una educación de calidad y contribuir al desarrollo de la sociedad.
        </p>
        <h2 class="main__subtitle">Nuestra Misión</h2>
        <p class="main__description">
          La misión de UNAN León es promover la formación integral de profesionales, la generación de conocimiento científico y tecnológico, y la promoción de la cultura y el arte, en función del desarrollo humano sostenible y la construcción de una sociedad justa y equitativa.
        </p>
        <h2 class="main__subtitle">Nuestros Programas Académicos</h2>
        <p class="main__description">
          UNAN León ofrece una amplia gama de programas académicos, desde licenciaturas hasta posgrados, que abarcan diversas disciplinas. Nuestros programas están diseñados para brindar una educación de alta calidad y preparar a los estudiantes para el éxito en sus carreras.
        </p>
        <h2 class="main__subtitle">Investigación y Desarrollo</h2>
        <p class="main__description">
          La investigación desempeña un papel fundamental en UNAN León. Nuestros investigadores y académicos trabajan en proyectos innovadores en áreas que van desde la ciencia y la tecnología hasta las ciencias sociales y las humanidades. Estamos comprometidos con el avance del conocimiento y la contribución al desarrollo de la sociedad.
        </p>
      </main>
    </div>
  </template>
  
  <style scoped>
  .main-container {
    display: flex;
    flex-direction: column;
    align-items: center;
    padding: 20px;
    background: #005b96;
    color: white;
  }
  
  .main {
    max-width: 800px;
    text-align: center;
  }
  
  .main__title {
    font-size: 32px;
    font-weight: bold;
    margin-bottom: 20px;
  }
  
  .main__description {
    font-size: 18px;
    line-height: 1.6;
    text-align: justify;
    margin-bottom: 30px;
  }
  
  .main__subtitle {
    font-size: 24px;
    font-weight: bold;
    margin-top: 30px;
  }
  </style>
  