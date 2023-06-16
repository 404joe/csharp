// var cnv_ctx = document.getElementById('canvas').getContext('2d');

/*
function rsz_cnvs(canvas) {
  var width = canvas.clientWidth;
  var height = canvas.clientHeight;
  if (width != canvas.width || height != canvas.height) {
    canvas.width = width;
    canvas.height = height;
  }
}*/

var canvas = document.getElementById('canvas');
var gl = canvas.getContext('webgl');
var startTime = new Date().getTime(); // Get start time for animating

// ----- Uniform ----- //
function Uniform( name, suffix ) {
  this.name = name;
  this.suffix = suffix;
  this.location = gl.getUniformLocation( program, name );
}

Uniform.prototype.set = function( ...values ) {
  var method = 'uniform' + this.suffix;
  var args = [ this.location ].concat( values );
  gl[ method ].apply( gl, args );
};

// ----- Rect ----- //
function Rect( gl ) {
  var buffer = gl.createBuffer();
  gl.bindBuffer( gl.ARRAY_BUFFER, buffer );
  gl.bufferData( gl.ARRAY_BUFFER, Rect.verts, gl.STATIC_DRAW );
}

Rect.verts = new Float32Array([
  -1, -1,
   1, -1,
  -1,  1,
   1,  1,
]);

Rect.prototype.render = function( gl ) {
  gl.drawArrays( gl.TRIANGLE_STRIP, 0, 4 );
};

//  <!-- script id="fragment-shader" type="x-shader/x-fragment"> </script-->  
const fragment_shader = `
  // Author @patriciogv - 2015 http://patriciogonzalezvivo.com
  #ifdef GL_ES
    precision lowp float;
  #endif
  
  uniform vec2 u_resolution;
  uniform float u_time;
  
  float random (in vec2 _st) {
    return fract(cos(dot(_st.xy, vec2(12.9898, 78.233))) * 43758.5453123);
  }
  
  // Based on Morgan McGuire @morgan3d https://www.shadertoy.com/view/4dS3Wd
  float noise (in vec2 _st) {
    vec2 i = floor(_st);
    vec2 f = fract(_st);
    
    // Four corners in 2D of a tile
    float a = random(i);
    float b = random(i + vec2(1.0, 0.0) );
    float c = random(i + vec2(0.0, 1.0) );
    float d = random(i + vec2(1.0, 1.0) );
    
    vec2 u = f * f; //* (3.0 - 2.0 * f);
     
    return mix(a, b, u.x) + ( (c - a)* u.y * (1.0 - u.x) ) + ( (d - b) * u.x * u.y );      
  }
  
  #define NUM_OCTAVES 5
  
  float fbm ( in vec2 _st) {
      float v = 0.0;
      float a = 0.4; //0.5
      mat2 rot = mat2(-1, 0, 0, -1);    // Rotate to reduce axial bias
      for (int i = 0; i < NUM_OCTAVES; i++ ) {
          v   += a * noise(_st);
          _st  = rot * _st * 2.0;
          a   *= 0.5; 
      }
      return v;  // v = (v + 1.0) / 2.0; // Map range from [-1, 1] to [0, 1]
      
  }
  
  void main() {
    vec2 st = gl_FragCoord.xy / u_resolution.xy * 3.0;
    
    vec2 r = vec2(1.0);
    r.x = fbm(st + 1.0 + vec2(1.7, 9.2) + 0.15  * u_time);
    r.y = fbm(st + 1.0 + vec2(8.3, 2.8) + 0.126 * u_time);
    
    float f = fbm(st + r);
    
    vec3 color = mix(vec3(0.0)           ,     // Modified blueish color    
                     vec3(0.0, 0.4, 1.0) ,  
                     clamp(length(r.x), 1.0, 1.0));
    
    gl_FragColor = vec4((f * f * f + 0.6 * f * f + 0.5 * f) * color, 1.0);
  } `;

// <!-- script id="vertex-shader" type="x-shader/x-vertex"> </script -->  
const vertex_shader = `
  attribute vec2 a_position;
  
  void main() {
    gl_Position = vec4( a_position, 0, 1 );
  } `;

// ----- init WebGL ----- //

// create program
var program = gl.createProgram();
// add shaders
var vertexShaderSource = vertex_shader; // document.querySelector('#vertex-shader').text;
var fragmentShaderSource = fragment_shader;// document.querySelector('#fragment-shader').text;
addShader( vertexShaderSource, gl.VERTEX_SHADER );
addShader( fragmentShaderSource, gl.FRAGMENT_SHADER );
// link & use program
gl.linkProgram( program );
gl.useProgram( program );

// create fragment uniforms
var uResolution = new Uniform( 'u_resolution', '2f' );
var uTime = new Uniform( 'u_time', '1f' );

// create position attrib
var billboard = new Rect( gl );
var positionLocation = gl.getAttribLocation( program, 'a_position' );
gl.enableVertexAttribArray( positionLocation );
gl.vertexAttribPointer( positionLocation, 2, gl.FLOAT, false, 0, 0 );

// resize 
var width, height;
width  = canvas.width  = 200;  // window.innerWidth / 3;
height = canvas.height = 200;  // window.innerHeight / 3;
uResolution.set( width, height );
gl.viewport( 0, 0, width, height );

animate();

// ----- addShader ----- //    
function addShader( source, type ) {
  var shader = gl.createShader( type );
  gl.shaderSource( shader, source );
  gl.compileShader( shader );
  var isCompiled = gl.getShaderParameter( shader, gl.COMPILE_STATUS );
  if ( !isCompiled ) {
    throw new Error( 'Shader compile error: ' + gl.getShaderInfoLog( shader ) );
  }
  gl.attachShader( program, shader );
}

// ----- render ----- //
function animate() {
  var now = new Date().getTime();  // update
  var currentTime = ( now - startTime ) / 1000;
  uTime.set( currentTime );
  billboard.render( gl );           
  setTimeout(function() { requestAnimationFrame(animate); }, 16); // render
}
