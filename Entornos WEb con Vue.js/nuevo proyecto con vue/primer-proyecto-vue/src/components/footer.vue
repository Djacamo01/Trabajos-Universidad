<template>
    <footer class="footer">
      <div class="footer__container">
        <div class="footer__section">
          <h3 class="footer__section-title">Contacto</h3>
          <p class="footer__section-text">Teléfono: 123-456-7890</p>
          <p class="footer__section-text">Email: contacto@unanleon.edu.ni</p>
        </div>
  
        <div class="footer__section">
          <h3 class="footer__section-title">Redes Sociales</h3>
          <ul class="footer__section-list">
            <li><a href="#">Facebook</a></li>
            <li><a href="#">Twitter</a></li>
            <li><a href="#">Instagram</a></li>
          </ul>
        </div>
  
        <div class="footer__section">
          <h3 class="footer__section-title">Enlaces de Interés</h3>
          <ul class="footer__section-list">
            <li><a href="#">Noticias</a></li>
            <li><a href="#">Eventos</a></li>
            <li><a href="#">Biblioteca</a></li>
            <li><a href="#">Admisiones</a></li>
            <li>Donald Miguel Jacamo Estrada 22-00023-1</li>
            <li> Juan Carlos Avenda;o Munguia 22-00358-1</li>
            <li> Kendry Josue Medrano Nuñes 22-07521-1</li>
            <!-- Agrega más enlaces aquí -->
          </ul>
        </div>
      </div>
    </footer>
  </template>
  
  <style>
  .footer {
      background-color: #003366;
      color: white;
      padding: 20px 10px;
      position: relative;
      bottom: 0;
      width: 100%;
      z-index: 1; /* Asegura que el footer esté en la parte superior de otros elementos */
    }
    
    .footer__container {
      display: flex;
      justify-content: space-between;
      max-width: 1200px;
      margin: 0 auto;
      align-items: flex-start;
    }
    
    .footer__section {
      flex-basis: 30%;
      margin-bottom: 30px;
    }
    
    .footer__section-title {
      font-size: 20px;
      font-weight: bold;
      margin-bottom: 20px;
    }
    
    .footer__section-text {
      font-size: 16px;
      margin: 0;
    }
    
    .footer__section-list {
      list-style: none;
      padding: 0;
    }
    
    .footer__section-list li {
      margin-bottom: 10px;
    }
    
    .footer__section-list a {
      color: white;
      text-decoration: none;
    }
  </style>
  