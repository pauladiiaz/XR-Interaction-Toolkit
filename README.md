# Práctica: XR Interaction Toolkit

## Paquetes instalados
Para realizar la práctica se han instalado los siguientes paquetes:
- XR Interaction Toolkit
- Meta XR All-in-One SDK
- Meta XR Simulator

## Activar OpenXR + Meta en el proyecto
Dentro de Edit -> Project Settings -> XR Plug-in Management, se ha activado OpenXR tanto paara PC como para Android.

## Configuración de OpenXR
Dentro de Edit -> Project Settings -> XR Plug-in Management -> OpenXR:
- PC: se han activado Meta Quest y Meta XR y los profiles incluidos son Eye Gaze Interaction Profile y Meta Quest Touch Pro Controller Profile.
- Android: se han activado Meta XR y los profiles incluidos son Eye Gaze Interaction Profile, Meta Quest Touch Pro Controller Profile y Hand Interaction Profile.

## Configurar la escena
Se ha eliminado la cámara principal de la escena y se ha añadido un XR Origin (XR Rig) que es un prefab incluido en el XR Interaction Toolkit.

## Ejercicio

Se han creado dos cubos, uno que está cerca y otro que está lejos. Al cubo cercano se le añadió el script [CuboCercano.cs](Assets/Scripts/CuboCercano.cs) que permite agarrarlo. Al cubo lejano se le añadió el script [CuboLejano.cs](Assets/Scripts/CuboLejano.cs) que permite cambiar su color al tocarlo con el raycast.

Al cubo cercano se le añadieron los siguientes componentes:
- Box Collider
- Rigidbody 
- XR Grab Interactable

Y al cubo lejano se le añadieron los siguientes componentes:
- Box Collider
- XR Simple Interactable
- Rigidbody sin usar gravedad.

En el Right Controller > Near-Far Interactor a Interactor Events se añadieron los eventos OnSelectEnter y OnSelectExit del script del cubo lejano.

## Problemas
Cuando se agarra el cubo cercano, el lejano cambia de color sin seleccionarlo. Se intentó arreglar añadiendo capas de interacción y asingnándolas a los interactores y a los objetos, pero hacía que no se pudiera agarrar el cubo cercano. 

## Video
[![Video de la práctica](https://user-attachments.githubusercontent.com/5224d384-197c-488b-839b-78278a326e5e/1f3f1f3a-5f7e-4f6e-8f4b-1c4e3e4b5c6d/video_thumbnail.png)](https://github.com/user-attachments/assets/5224d384-197c-488b-839b-78278a326e5e)