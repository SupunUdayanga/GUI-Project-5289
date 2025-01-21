import React from 'react';
import './contact.css';

function Contact() {
  return (
    <div className="contact-container">
      {/* Hero Section */}
      <div className="contact-hero">
        <h1>Contact Us</h1>
        <p>
          Have questions or need assistance? Feel free to reach out to us through the details below.
        </p>
      </div>

      {/* Contact Information Section */}
      <div className="contact-info">
        <h2>Get In Touch</h2>
        <p><strong>Phone:</strong> +1 (123) 456-7890</p>
        <p><strong>Email:</strong> support@happypawshub.com</p>
      </div>
    </div>
  );
}

export default Contact;
