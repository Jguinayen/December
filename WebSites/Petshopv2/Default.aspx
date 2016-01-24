<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage-1.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <script src="js/modernizr-2.6.2-respond-1.1.0.min.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

       <section id="main-slider" class="no-margin">
        <div class="carousel slide">
            <ol class="carousel-indicators">
                <li data-target="#main-slider" data-slide-to="0" class="active"></li>
                <li data-target="#main-slider" data-slide-to="1"></li>
                <li data-target="#main-slider" data-slide-to="2"></li>
            </ol>
            <div class="carousel-inner">
                <div class="item active" style="background-image: url(img/slides/1.jpg);">
                    <div class="container">
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="carousel-content centered">
                                    
                                    <h2 class="animation animated-item-1" style="color:#0094ff; display:block; width:300px;">
                                        <%--<span class="animation animated-item-1" style="font-size:18pt; color:#0094ff;">Welcome to</span>--%>
                                        PETSHOPPE GROOMING!</h2>
                                    <p class="animation animated-item-2" style="color:#ffffff; display:block; width:450px; margin-top:15px;">Safe and modern grooming facilities.</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div><!--/.item-->
                <div class="item" style="background-image: url(img/slides/2.jpg);">
                    <div class="container">
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="carousel-content centered">
                                    
                                    <h2 class="animation animated-item-1" style="color:#ffffff; display:block; width:300px;">
                                        <%--<span class="animation animated-item-1" style="font-size:18pt; color:#ffffff;">Welcome to</span>--%>
                                        PETSHOPPE GROOMING!</h2>
                                    <p class="animation animated-item-2" style="color:#ffffff; display:block; width:450px; margin-top:15px;">Make an Appointment at your local Petshoppe Groomer today.</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div><!--/.item-->
                <div class="item" style="background-image: url(img/slides/3.jpg)"> 
                    <div class="container">
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="carousel-content centered" style="margin-top:10px;">
                                    <h2 class="animation animated-item-1" style="color:#aec62c; display:block; width:300px;">
                                        PETSHOPPE GROOMING!</h2>
                                    <p class="animation animated-item-2" style="color:#ffffff; display:block; width:450px; font-size:12pt; margin-top:15px;">Look good, smell great - keep your pet healthy and happy with regular grooming to enhance your dogs coat.</p>
                                    <br>
									<a class="btn btn-md animation animated-item-3" href="#">Learn More</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div><!--/.item-->
            </div><!--/.carousel-inner-->
        </div><!--/.carousel-->
        <a class="prev hidden-xs" href="#main-slider" data-slide="prev">
            <i class="icon-angle-left"></i>
        </a>
        <a class="next hidden-xs" href="#main-slider" data-slide="next">
            <i class="icon-angle-right"></i>
        </a>
    </section><!--/#main-slider-->


    <!-- Call to Action Bar -->
	    <div class="section section-dark">
			<div class="container">
				<div class="row">
					<div class="col-md-12">
						<div class="calltoaction-wrapper">
							<h3>Welcome to <span style="color:#aec62c; text-transform:uppercase;font-size:24px;">Petshoppe!</span> Everything for Pets!</h3> <!--<a href="http://www.vactualart.com/portfolio-item/basica-a-free-html5-template/" class="btn btn-orange">Download here!</a>-->
						</div>
					</div>
				</div>
			</div>
		</div>
		<!-- End Call to Action Bar -->


		<!-- Services -->
       <%-- <div class="section section-white">
	        <div class="container">
	        	<div class="row">
	        		<div class="col-md-4 col-sm-6">
	        			<div class="service-wrapper">
		        			<i class="icon-home"></i>
		        			<h3>Aliquam in adipiscing</h3>
		        			<p>Praesent rhoncus mauris ac sollicitudin vehicula. Nam fringilla turpis turpis, at posuere turpis aliquet sit amet condimentum</p>
		        			<a href="#" class="btn">Read more</a>
		        		</div>
	        		</div>
	        		<div class="col-md-4 col-sm-6">
	        			<div class="service-wrapper">
		        			<i class="icon-briefcase"></i>
		        			<h3>Curabitur mollis</h3>
		        			<p>Suspendisse eget libero mi. Fusce ligula orci, vulputate nec elit ultrices, ornare faucibus orci. Aenean lectus sapien, vehicula</p>
		        			<a href="#" class="btn">Read more</a>
		        		</div>
	        		</div>
	        		<div class="col-md-4 col-sm-6">
	        			<div class="service-wrapper">
		        			<i class="icon-calendar"></i>
		        			<h3>Vivamus mattis</h3>
		        			<p>Phasellus posuere et nisl ac commodo. Nulla facilisi. Sed tincidunt bibendum cursus. Aenean vulputate aliquam risus rutrum scelerisque</p>
		        			<a href="#" class="btn">Read more</a>
		        		</div>
	        		</div>
	        	</div>
	        </div>
	    </div>--%>
	    <!-- End Services -->


<%--<hr>--%>

		<!-- Our Portfolio -->	

        <div class="section section-white">
	        <div class="container">
	        	<div class="row">
	
				<div class="section-title">
				<h1 style="font-size:20pt;">What's New</h1>
				</div>
		
		
			<ul class="grid cs-style-3" style="margin-top:-50px;">
	        	<div class="col-md-4 col-sm-6">
					<figure>
						<img src="img/portfolio/4.jpg" alt="img04">
						<figcaption>
							<h3>Shop Online</h3>
							<span>Petshoppe</span>
							<a href="Default.aspx">Take a look</a>
						</figcaption>
					</figure>
	        	</div>	
				<div class="col-md-4 col-sm-6">
					<figure>
						<img src="img/portfolio/1.jpg" alt="img01">
						<figcaption>
							<h3>Events</h3>
							<span>Petshoppe</span>
							<a href="Default.aspx">Take a look</a>
						</figcaption>
					</figure>
				</div>
				<div class="col-md-4 col-sm-6">
					<figure>
						<img src="img/portfolio/2.jpg" alt="img02">
						<figcaption>
							<h3>Pet Grooming</h3>
							<span>Petshoppe</span>
							<a href="Default.aspx">Take a look</a>
						</figcaption>
					</figure>
				</div>
				<div class="col-md-4 col-sm-6">
					<figure>
						<img src="img/portfolio/5.jpg" alt="img05">
						<figcaption>
							<h3>Services</h3>
							<span>Petshoppe</span>
							<a href="Default.aspx">Take a look</a>
						</figcaption>
					</figure>
				</div>
				<div class="col-md-4 col-sm-6">
					<figure>
						<img src="img/portfolio/3.jpg" alt="img03">
						<figcaption>
							<h3>About Us</h3>
							<span>Petshoppe</span>
							<a href="Default.aspx">Take a look</a>
						</figcaption>
					</figure>
				</div>
				<div class="col-md-4 col-sm-6">
					<figure>
						<img src="img/portfolio/6.jpg" alt="img06">
						<figcaption>
							<h3>Vet Care</h3>
							<span>Petshoppe</span>
							<a href="Default.aspx">Take a look</a>
						</figcaption>
					</figure>
				</div>
			</ul>
	        	</div>
	        </div>
	    </div>
		<!-- Our Portfolio -->
			
<hr style="padding: 0px; margin:0px;">

		<!-- Our Clients -->
	    <div class="section" style="background-color:#cccccc;">
	    	<div class="container">
			
				<div class="section-title">
				<h1 style="font-size:20pt;">Popular Products</h1>
				</div>

				<div class="clients-logo-wrapper text-center row">
					<div class="col-lg-1 col-md-1 col-sm-3 col-xs-6"><a href="#"><img src="img/logos/logo-1.jpg" alt="Client Name"></a></div>
					<div class="col-lg-1 col-md-1 col-sm-3 col-xs-6"><a href="#"><img src="img/logos/logo-2.jpg" alt="Client Name"></a></div>
					<div class="col-lg-1 col-md-1 col-sm-3 col-xs-6"><a href="#"><img src="img/logos/logo-3.jpg" alt="Client Name"></a></div>
					<div class="col-lg-1 col-md-1 col-sm-3 col-xs-6"><a href="#"><img src="img/logos/logo-1.jpg" alt="Client Name"></a></div>
					<div class="col-lg-1 col-md-1 col-sm-3 col-xs-6"><a href="#"><img src="img/logos/logo-2.jpg" alt="Client Name"></a></div>
					<div class="col-lg-1 col-md-1 col-sm-3 col-xs-6"><a href="#"><img src="img/logos/logo-3.jpg" alt="Client Name"></a></div>
					<div class="col-lg-1 col-md-1 col-sm-3 col-xs-6"><a href="#"><img src="img/logos/logo-1.jpg" alt="Client Name"></a></div>
					<div class="col-lg-1 col-md-1 col-sm-3 col-xs-6"><a href="#"><img src="img/logos/logo-2.jpg" alt="Client Name"></a></div>
					<div class="col-lg-1 col-md-1 col-sm-3 col-xs-6"><a href="#"><img src="img/logos/logo-3.jpg" alt="Client Name"></a></div>
					<div class="col-lg-1 col-md-1 col-sm-3 col-xs-6"><a href="#"><img src="img/logos/logo-1.jpg" alt="Client Name"></a></div>
					<%--<div class="col-lg-1 col-md-1 col-sm-3 col-xs-6"><a href="#"><img src="img/logos/logo-11.jpg" alt="Client Name"></a></div>
					<div class="col-lg-1 col-md-1 col-sm-3 col-xs-6"><a href="#"><img src="img/logos/logo-12.jpg" alt="Client Name"></a></div>--%>
				</div>
			</div>
	    </div>
	    <!-- End Our Clients -->


		
            <!-- Javascripts -->
        <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
        <script>window.jQuery || document.write('<script src="js/jquery-1.9.1.min.js"><\/script>')</script>
        <script src="js/bootstrap.min.js"></script>
		
		<!-- Scrolling Nav JavaScript -->
		<script src="js/jquery.easing.min.js"></script>
		<script src="js/scrolling-nav.js"></script>	

</asp:Content>

