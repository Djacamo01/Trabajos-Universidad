<template>
    <header class="header">
      <div class="header__container">
        <div class="header__logo">
          <img src="src/assets/imagenes/Logo.png" alt="Logo de la Universidad" class="header__logo-image">
        </div>
        <div class="header__content">
          <h1 class="header__title">UNIVERSIDAD NACIONAL AUTONOMA DE NICARAGUA</h1>
          <nav class="header__nav">
            <ul class="header__nav-list">
              <li><a href="#nosotros">Nosotros</a></li>
              <li><a href="#carreras">Carreras</a></li>
              <template>
                
                <li><router-link to="/contacto.vue">Contacto</router-link></li>
                
              </template>
            </ul>
          </nav>
        </div>
      </div>
    </header>
  </template>
  

  
  <style scoped>
  .header {
    background-color: #003366;
    color: white;
    padding: 20px 0;
  }
  
  .header__container {
    max-width: 1200px;
    margin: 0 auto;
    display: flex;
    justify-content: space-between;
    align-items: center;
  }
  
  .header__logo-image {
    max-width: 100px; /* Ajusta el tamaño del logo según tus necesidades */
  }
  
  .header__title {
    font-size: 24px;
    font-weight: bold;
    margin: 0;
  }
  
  .header__nav {
    font-size: 16px;
  }
  
  .header__nav-list {
    list-style: none;
    display: flex;
    gap: 20px;
    padding: 0;
  }
  
  .header__nav-list a {
    color: white;
    text-decoration: none;
  }
  </style>
  
