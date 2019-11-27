using Game.Players.Old;
using Game.TDD.Players.Looking;
using Game.TDD.Players.Movement;
using UnityEngine;

namespace Game.TDD.Players
{
	public sealed class PlayerComponent : BaseComponent<Player>
	{
		[Header("Player component")]
		[SerializeField] private PlayerInput playerInput;

		[SerializeField] private PlayerMovementComponent playerMovementComponent;
		[SerializeField] private PlayerLookingComponent playerLookingComponent;

		protected override Player CreateInstance() => new Player(transform, playerInput,
			playerMovementComponent.Instance, playerLookingComponent.Instance);

		private void FixedUpdate() => Instance.FixedUpdate();
	}
}