extends CharacterBody3D

func _physics_process(delta: float) -> void:
	look_at_cursor()

func look_at_cursor():
	var target_plane_mouse = Plane(Vector3(0,1,0), position.y)
	var ray_length = 1000
	var mouse_position = get_viewport().get_mouse_position()
	var from = $CameraPivot/PlayerCamera3D.project_ray_origin(mouse_position)
	var to = from + $CameraPivot/PlayerCamera3D.project_ray_normal(mouse_position) * ray_length
	var cursor_position_on_plane = target_plane_mouse.intersects_ray(from, to)
	
	look_at(cursor_position_on_plane, Vector3.UP, 0)
	
