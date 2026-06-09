// Active navigation link
document.addEventListener('DOMContentLoaded', function() {
  const currentLocation = location.pathname;
  const menuItems = document.querySelectorAll('.navbar-nav .nav-link');

  menuItems.forEach(item => {
    if (item.getAttribute('href') === currentLocation.split('/').pop() || 
        (currentLocation.split('/').pop() === '' && item.getAttribute('href') === 'index.html')) {
      item.classList.add('active');
    }
  });
});

// Smooth scrolling for anchor links
document.querySelectorAll('a[href^="#"]').forEach(anchor => {
  anchor.addEventListener('click', function (e) {
    e.preventDefault();
    const target = document.querySelector(this.getAttribute('href'));
    if (target) {
      target.scrollIntoView({ behavior: 'smooth' });
    }
  });
});

// Contact form handling
const contactForm = document.getElementById('contactForm');
if (contactForm) {
  contactForm.addEventListener('submit', function(e) {
    e.preventDefault();
    
    const name = document.getElementById('name').value;
    const email = document.getElementById('email').value;
    const phone = document.getElementById('phone').value;
    const service = document.getElementById('service').value;
    const message = document.getElementById('message').value;
    
    if (name && email && message) {
      // In a real application, you would send this to a server
      alert('Thank you for your message! We will get back to you soon.');
      contactForm.reset();
    } else {
      alert('Please fill in all required fields.');
    }
  });
}

// Mobile menu toggle
const toggler = document.querySelector('.navbar-toggler');
if (toggler) {
  toggler.addEventListener('click', function() {
    const navMenu = document.querySelector('.navbar-collapse');
    if (navMenu) {
      navMenu.classList.toggle('show');
    }
  });
}

// Navbar background on scroll
window.addEventListener('scroll', function() {
  const navbar = document.querySelector('.navbar');
  if (window.scrollY > 0) {
    navbar.style.boxShadow = '0 4px 16px rgba(0, 0, 0, 0.15)';
  } else {
    navbar.style.boxShadow = '0 2px 8px rgba(0, 0, 0, 0.1)';
  }
});
